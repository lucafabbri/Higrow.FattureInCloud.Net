using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class AcquistiListaResponse:GenericSuccessResponse
    {
        public List<AcquistiLight> lista_documenti { get; set; }
    }
}
