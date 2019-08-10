using Higrow.FattureInCloud.Net.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Services.v1
{
    public class MagazzinoService:BaseService
    {
        public MagazzinoService() : base() { }

        // POST "/arrivimerce/lista"
        public async Task<ArriviListaResponse> Lista(ArriviListaRequest request)
        {
            return JsonConvert.DeserializeObject<ArriviListaResponse>(await GenericPostAsync("/arrivimerce/lista", request));
        }

        // POST "/arrivimerce/dettagli"
        public async Task<ArriviDettagliResponse> Dettagli(ArriviDettagliRequest request)
        {
            return JsonConvert.DeserializeObject<ArriviDettagliResponse>(await GenericPostAsync("/arrivimerce/dettagli", request));
        }
    }
}
