using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class AnagraficaListaRequest : JSONRequest
    {
        public AnagraficaListaRequest()
        {
            pagina = 1;
        }
        public string filtro { get; set; }
        public string id { get; set; }
        public string nome { get; set; }
        public string cf { get; set; }
        public string piva { get; set; }
        public int pagina { get; set; }
    }
}
