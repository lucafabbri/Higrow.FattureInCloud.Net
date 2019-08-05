using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class InfoListaRequest:JSONRequest
    {
        public int anno_competenza { get; set; }
        public List<string> campi { get; set; }
    }
}
