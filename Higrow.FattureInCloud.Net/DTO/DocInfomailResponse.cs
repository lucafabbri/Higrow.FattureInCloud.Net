using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class DocInfomailResponse:GenericSuccessResponse
    {
        public string mail_destinatario { get; set; }
        public List<DocInfomailMail> mail_mittente { get; set; }
        public string mail_cc { get; set; }
        public string oggetto_default { get; set; }
        public string messaggio_default { get; set; }
        public bool esiste_documento { get; set; }
        public bool esiste_ddt { get; set; }
        public bool esiste_fa { get; set; }
        public bool esiste_allegato { get; set; }
    }
}
