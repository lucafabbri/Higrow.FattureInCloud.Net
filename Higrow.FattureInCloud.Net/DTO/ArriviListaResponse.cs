using System.Collections.Generic;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class ArriviListaResponse:GenericSuccessResponse
    {
        public List<ArriviLight> lista_documenti { get; set; }
    }
}