using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Certweb.Armazenamento.Modelo;
using Newtonsoft.Json;

namespace Certweb.Armazenamento.Arquivo
{
    public class GerenciadorLinks
    {
        private static string nomeArquivo = "links.txt";
        private static List<Link> listaLinks { get; set; }
        public static void AdicionarLink(Link link)
        {
            listaLinks.Add(link);
        }
        public static void RemoverLink(Link link)
        {
            listaLinks.Remove(link);
        }
        public static List<Link> LerLinks()
        {
            if(listaLinks == null)
            {
                string conteudoArquivo = new GerenciadorArquivos().LerArquivo(nomeArquivo);

                if (!string.IsNullOrEmpty(conteudoArquivo))
                {
                    listaLinks = JsonConvert.DeserializeObject<List<Link>>(conteudoArquivo);
                    return listaLinks;
                }
                else
                {
                    listaLinks = new List<Link>();
                    return listaLinks;
                }
            }else 
            {
                return listaLinks; 
            }
        }
        public static void SalvarLinks()
        {
            string jsonLink = JsonConvert.SerializeObject(listaLinks);

            new GerenciadorArquivos().Escrever(nomeArquivo, jsonLink);
        }

    }
}
