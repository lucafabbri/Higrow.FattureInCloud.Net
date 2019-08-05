using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class DocDettagliRequest:JSONRequest
    {
        public string id { get; set; }
        public string token { get; set; }
    }
}
