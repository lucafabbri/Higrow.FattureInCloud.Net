using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class CorrispettiviListaRequest: JSONRequest
    {
        public int anno { get; set; }
        public string tipo { get; set; }
        public string data_inizio { get; set; }
        public string data_fine { get; set; }
        public string id { get; set; }
    }
}
