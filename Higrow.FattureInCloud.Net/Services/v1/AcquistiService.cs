using Higrow.FattureInCloud.Net.DTO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Services.v1
{
    public class AcquistiService:BaseService
    {
        public AcquistiService() : base() { }

        // POST "/acquisti/lista"
        public async Task<AcquistiListaResponse> Lista(AcquistiListaRequest request)
        {
            return JsonConvert.DeserializeObject<AcquistiListaResponse>(await GenericPostAsync("/acquisti/lista", request));
        }

        // POST "/acquisti/dettagli"
        public async Task<AcquistiDettagliResponse> Dettagli(AcquistiDettagliRequest request)
        {
            return JsonConvert.DeserializeObject<AcquistiDettagliResponse>(await GenericPostAsync("/acquisti/dettagli", request));
        }

        // POST "/acquisti/nuovo"
        public async Task<AcquistiNuovoResponse> Nuovo(AcquistiNuovoRequest request)
        {
            return JsonConvert.DeserializeObject<AcquistiNuovoResponse>(await GenericPostAsync("/acquisti/nuovo", request));
        }

        // POST "/acquisti/modifica"
        public async Task<AcquistiModificaResponse> Modifica(AcquistiModificaRequest request)
        {
            return JsonConvert.DeserializeObject<AcquistiModificaResponse>(await GenericPostAsync("/acquisti/modifica", request));
        }

        // POST "/acquisti/elimina"
        public async Task<GenericSuccessResponse> Elimina(AcquistiEliminaRequest request)
        {
            return JsonConvert.DeserializeObject<GenericSuccessResponse>(await GenericPostAsync("/acquisti/elimina", request));
        }
    }
}
