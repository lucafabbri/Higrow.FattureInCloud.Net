using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class AcquistiListaRequest:JSONRequest
    {
        public int anno { get; set; }
        public string tipo { get; set; }
        public string data_inizio { get; set; }
        public string data_fine { get; set; }
        public string fornitore { get; set; }
        public string id_fornitore { get; set; }
        public string saldato { get; set; }
        public string mostra_link_allegato { get; set; }
    }
}
