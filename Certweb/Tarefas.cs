using Certweb.Armazenamento.Arquivo;
using Certweb.Armazenamento.Modelo;
using Certweb.Internet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Certweb
{
    public partial class Tarefas : UserControl
    {
        private Painel _painel;
        private TelaInicial _form1;

        public Tarefas()
        {
            InitializeComponent();
        }
        public void SetPainels(TelaInicial form,Painel painel)
        {
            _form1 = form;
            _painel = painel;
            CarregarLinks();
        }

        public void CarregarLinks()
        {
            pnFlowLinks.Controls.Clear();
            List<Link> lista = GerenciadorLinks.LerLinks();

            if (lista != null)
            {
                int tamanhoFonte = 8;

                foreach (var link in lista)
                {
                    var pn = new FlowLayoutPanel();
                    pn.FlowDirection = FlowDirection.LeftToRight;
                    pn.Size = new Size(408, 20);
                    pn.WrapContents = false;

                    var descricao = new Label() { Text = link.Descricao, Font = new Font(Texto.FONT, tamanhoFonte), ForeColor = Color.FromArgb(68, 68, 68), Width = 200 };
                    var endereco = new Label() { Text = link.Endereco, Font = new Font(Texto.FONT, tamanhoFonte), ForeColor = Color.FromArgb(134, 134, 134) , Width = 200 };


                    pn.Controls.Add(descricao);
                    pn.Controls.Add(endereco);

                    pnFlowLinks.Controls.Add(pn);
                }
            }
        }

        public void btnExecutar_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(Executar);
            th.IsBackground = true;
            th.Start(_form1);
        }

        private void Executar(Object _form)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            List<Link> lista = GerenciadorLinks.LerLinks();

            double TotalLinks = lista.Count;
            double LinkProcessamentoAtual = 0;
            Painel.Modelo.QuantidadeErros = 0;

            foreach (var link in lista)
            {
                GerenciadorDeAcesso.AcessarLink(link.Endereco);
                LinkProcessamentoAtual++;

                double porcentagem = (LinkProcessamentoAtual / TotalLinks) * 100;
                if (this.InvokeRequired)
                {
                    Invoke(new Action(() =>
                    {
                        ProgressBar.Value = Convert.ToInt32(porcentagem);
                    }));
                }
            }
            sw.Stop();

            Painel.Modelo.TempoDecorrido = sw.Elapsed;
            Painel.Modelo.UltimaExecucao = DateTime.Now;

            if (_painel.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    _painel.AtualizarTextoTela();
                }));
            }

            ((TelaInicial) _form1).CertwebSystemTray.ShowBalloonTip(1000, "Certweb", Texto.MSG_SUCESSO_TAREFAS, ToolTipIcon.Info);
        }
    }
}
