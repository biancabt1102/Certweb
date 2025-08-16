using Certweb.Armazenamento.Arquivo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certweb
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            GerenciadorLinks.LerLinks();
            InitializeComponent();
            painelVisivel(pnPainel);

            pnLinks.SetPainels(pnTarefas, pnPainel);
            pnTarefas.SetPainels(this,pnPainel);

        }
        private void redimensionarImagem(Button btn, int width, int height)
        {
            Image imagemOriginal = btn.Image;
            Bitmap imagemRedimensionada = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(imagemRedimensionada))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(imagemOriginal, 0,0, width, height);
            }

            btn.Image = imagemRedimensionada;
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextAlign = ContentAlignment.MiddleRight;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.Padding = new Padding(10,0,0,0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            redimensionarImagem(btnPainel, 40, 40);
            redimensionarImagem(btnPainelTarefas, 40, 40);
            redimensionarImagem(btnLink, 40, 40);
            redimensionarImagem(btnSobre, 40, 40);
        }

        private void CloseForm(object sender, EventArgs e)
        {
            GerenciadorLinks.SalvarLinks();
            GerenciadorTelaPainel.SalvarDados(Painel.Modelo);
            Application.Exit();
        }

        private void btnClickPainel(object sender, EventArgs e)
        {
            moverIndicador((Button)sender);
            painelVisivel(pnPainel);
        }

        private void btnClickTarefas(object sender, EventArgs e)
        {
            moverIndicador((Button)sender);
            painelVisivel(pnTarefas);
        }

        private void btnClickLink(object sender, EventArgs e)
        {
            moverIndicador((Button)sender);
            painelVisivel(pnLinks);
        }

        private void btnClickSobre(object sender, EventArgs e)
        {
            moverIndicador((Button)sender);
            painelVisivel(pnSobre);
        }


        private void moverIndicador(Button btnMenu)
        {
            pnIndicador.Location = new Point(pnIndicador.Location.X,btnMenu.Location.Y);
        }

        private void painelVisivel(UserControl pn)
        {
            pnPainel.Visible = false;
            pnLinks.Visible = false;
            pnSobre.Visible = false;
            pnTarefas.Visible = false;

            pn.Visible = true;
        }

        private bool btnMousePressionado = false;
        private Point pontoInicialFormulario, pontoInicialCursor;
        private void pnDragDrop_MouseDown(object sender, MouseEventArgs e)
        {
            btnMousePressionado = true;
            pontoInicialFormulario = this.Location;
            pontoInicialCursor = Cursor.Position;
        }

        private void pnDragDrop_MouseUp(object sender, MouseEventArgs e)
        {
            btnMousePressionado = false;
        }

        private void ExecutarTarefas(object sender, EventArgs e)
        {
            pnTarefas.btnExecutar_Click(this, EventArgs.Empty);
        }

        private void pnDragDrop_MouseMove(object sender, MouseEventArgs e)
        {
            if (btnMousePressionado == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(pontoInicialCursor));
                this.Location = Point.Add(pontoInicialFormulario, new Size(dif));
            }
        }
    }
}
