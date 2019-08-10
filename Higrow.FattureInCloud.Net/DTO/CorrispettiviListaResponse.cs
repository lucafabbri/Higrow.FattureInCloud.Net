using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class CorrispettiviListaResponse:GenericSuccessResponse
    {
        public List<CorrispettiviDetailed> lista_corrispettivi { get; set; }
    }
}
