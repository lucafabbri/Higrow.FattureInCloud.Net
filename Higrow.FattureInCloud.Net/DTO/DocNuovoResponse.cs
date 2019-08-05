using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class DocNuovoResponse:GenericSuccessResponse
    {
        public int new_id { get; set; }
        public string token { get; set; }
    }
}
