using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class ProdottiListaRequest:JSONRequest
    {
        public string filtro { get; set; }
        public string id { get; set; }
        public string nome { get; set; }
        public string cod { get; set; }
        public string desc { get; set; }
        public string categoria { get; set; }
        public int pagina { get; set; }
    }
}
