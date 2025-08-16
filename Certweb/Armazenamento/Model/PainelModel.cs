using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certweb.Armazenamento.Modelo
{
    public class PainelModel
    {
        public TimeSpan TempoDecorrido {  get; set; }
        public DateTime UltimaExecucao { get; set; }
        public int QuantidadeErros { get; set; }
    }
}
