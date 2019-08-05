using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class JSONRequest : IJSONRequest
    {
        public string api_uid { get; set; }
        public string api_key { get; set; }
    }
}
