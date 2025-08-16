using Certweb.Armazenamento.Arquivo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Certweb.Armazenamento.Modelo;

namespace Certweb
{
    public partial class Painel : UserControl
    {
        public static PainelModel Modelo {  get; set; }
        public Painel()
        {
            InitializeComponent();
            Modelo = GerenciadorTelaPainel.LerDados();
            if (Modelo == null)
            {
                Modelo = new PainelModel();
                Modelo.QuantidadeErros = 0;
            }
            AtualizarTextoTela();
        }

        public void QuantidadeLinks()
        {
            List<Link> lista = GerenciadorLinks.LerLinks();
            if (lista != null)
            {
                lblQuantidade.Text = lista.Count.ToString();
            }
        }

        public void AtualizarTextoTela()
        {
            lblErrosOcorridos.Text = Painel.Modelo.QuantidadeErros.ToString();
            lblTempoDecorrido.Text = Painel.Modelo.TempoDecorrido.ToString("ss") + "s";
            lblUltimaExecucao.Text = Painel.Modelo.UltimaExecucao.ToString("HH:mm");
        }
    }
}
