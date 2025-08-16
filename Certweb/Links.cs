using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Certweb.Armazenamento.Arquivo;
using Certweb.Armazenamento.Modelo;

namespace Certweb
{
    public partial class Links : UserControl
    {
        private Link linkEmEdicao { get; set; }
        private Tarefas _tarefa;
        private Painel _painel;

        public Links()
        {
            InitializeComponent();
        }

        public void SetPainels(Tarefas tarefas, Painel painel)
        {
            _tarefa = tarefas;
            _painel = painel;
            CarregarLinks();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(linkEmEdicao == null)
            {
                Link link = new Link() { Descricao = txtDescricao.Text, Endereco = txtLink.Text};

                GerenciadorLinks.AdicionarLink(link);
                GerenciadorLinks.SalvarLinks();
            }
            else
            {
                linkEmEdicao.Descricao = txtDescricao.Text;
                linkEmEdicao.Endereco = txtLink.Text;

                linkEmEdicao = null;
            }

            txtDescricao.Text = Texto.TXT_DESCRICAO;
            txtLink.Text = Texto.TXT_LINK;

            CarregarLinks();
        }
        private void CarregarLinks()
        {
            _tarefa.CarregarLinks();
            _painel.QuantidadeLinks();
            pnFlowLinks.Controls.Clear();
            List<Link> lista = GerenciadorLinks.LerLinks();

            if (lista != null)
            {
                int tamanhoFonte = 8;

                foreach (var link in lista)
                {
                    var pn = new FlowLayoutPanel();
                    pn.FlowDirection = FlowDirection.LeftToRight;
                    pn.Size = new Size(893, 20);
                    pn.WrapContents = false;

                    var descricao = new Label() { Text = link.Descricao, Font = new Font(Texto.FONT, tamanhoFonte), ForeColor = Color.FromArgb(68, 68, 68), Width = 200 };
                    var endereco = new Label() { Text = link.Endereco, Font = new Font(Texto.FONT, tamanhoFonte), ForeColor = Color.FromArgb(134, 134, 134), Width = 200 };

                    var btnEditar = new LinkLabel() { Text = "Editar", Font = new Font(Texto.FONT, tamanhoFonte) };
                    var btnExcluir = new LinkLabel() { Text = "Excluir", Font = new Font(Texto.FONT, tamanhoFonte) };

                    pn.Controls.Add(descricao);
                    pn.Controls.Add(endereco);
                    pn.Controls.Add(btnEditar);
                    pn.Controls.Add(btnExcluir);

                    pnFlowLinks.Controls.Add(pn);

                    btnEditar.Click += delegate {EditarAction(link);};

                    btnExcluir.Click += delegate {ExcluirAction(link);};
                }
            }
        }

        private void EditarAction(Link link)
        {
            linkEmEdicao = link;

            txtDescricao.Text = link.Descricao;
            txtLink.Text = link.Endereco;
        }
        
        private void ExcluirAction(Link link)
        {
            GerenciadorLinks.RemoverLink(link);
            CarregarLinks();
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            var campo = (TextBox)sender;
            if (campo.Text == Texto.TXT_DESCRICAO)
            {
                campo.Text = String.Empty;
                campo.ForeColor = Color.Black;
            }
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            var campo = (TextBox)sender;
            if(campo.Text == String.Empty)
            {
                campo.Text = Texto.TXT_DESCRICAO;
                campo.ForeColor = Color.FromArgb(68,68,68);
            }
        }

        private void txtLink_Enter(object sender, EventArgs e)
        {
            var campo = (TextBox)sender;
            if(campo.Text == Texto.TXT_LINK)
            {
                campo.Text = String.Empty;
                campo.ForeColor = Color.Black;
            }
        }

        private void txtLink_Leave(object sender, EventArgs e)
        {
            var campo = (TextBox)sender;
            if (campo.Text == String.Empty)
            {
                campo.Text = Texto.TXT_LINK;
                campo.ForeColor = Color.FromArgb(68, 68, 68);
            }
        }
    }
}
