using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class AcquistiDettagliResponse:GenericSuccessResponse
    {
        public AcquistiDetailed dettagli_documento { get; set; }
    }
}
