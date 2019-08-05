using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public interface IJSONRequest
    {
        string api_uid { get; set; }
        string api_key { get; set; }
    }
}
