using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class DocListaRequest:JSONRequest
    {
        public DocListaRequest()
        {
            pagina = 1;
        }
        public int anno { get; set; }
        public string data_inizio { get; set; }
        public string data_fine { get; set; }
        public string cliente { get; set; }
        public string fornitore { get; set; }
        public string id_cliente { get; set; }
        public string id_fornitore { get; set; }
        public string saldato { get; set; }
        public string oggetto { get; set; }
        public string ogni_ddt { get; set; }
        public bool PA { get; set; }
        public string PA_tipo_cliente { get; set; }
        public int pagina { get; set; }
    }
}
