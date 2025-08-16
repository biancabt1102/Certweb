using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Certweb.Armazenamento.Arquivo
{
    public class GerenciadorArquivos
    {
        private string DiretorioProjeto = AppDomain.CurrentDomain.BaseDirectory;
        public string LerArquivo(string arquivo)
        {
            string caminho = DiretorioProjeto + arquivo;

            if (File.Exists(caminho))
            {
                using(StreamReader sr = new StreamReader(caminho))
                {
                    return sr.ReadToEnd();
                }
            }
            else
            {
                return null;
            }
        }

        public void Escrever(string arquivo, string conteudo)
        {
            string caminho = DiretorioProjeto + arquivo;

            using (StreamWriter sw = new StreamWriter(caminho))
            {
                sw.Write(conteudo);
            }
        }
    }
}
