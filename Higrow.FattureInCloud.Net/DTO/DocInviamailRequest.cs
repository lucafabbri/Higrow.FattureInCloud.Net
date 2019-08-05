using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class DocInviamailRequest:JSONRequest
    {
        public string id { get; set; }
        public string token { get; set; }
        public string mail_mittente { get; set; }
        public string mail_destinatario { get; set; }
        public string oggetto { get; set; }
        public string messaggio { get; set; }
        public bool includi_documento { get; set; }
        public bool invia_ddt { get; set; }
        public bool invia_fa { get; set; }
        public bool includi_allegato { get; set; }
        public bool invia_copia { get; set; }
        public bool allega_pdf { get; set; }
    }
}
