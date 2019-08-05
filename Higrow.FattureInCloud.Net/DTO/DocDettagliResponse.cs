using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class DocDettagliResponse:GenericSuccessResponse
    {
        public DocDetailed dettagli_documento { get; set; }
    }
}
