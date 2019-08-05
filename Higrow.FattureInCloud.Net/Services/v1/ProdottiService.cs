using Higrow.FattureInCloud.Net.DTO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Services.v1
{
    public class ProdottiService:BaseService
    {
        public ProdottiService() : base() { }

        // POST "/prodotti/lista"
        public async Task<ProdottiListaResponse> Lista(ProdottiListaRequest request)
        {
            return JsonConvert.DeserializeObject<ProdottiListaResponse>(await GenericPostAsync("/prodotti/lista", request));
        }

        // POST "/prodotti/nuovo"
        public async Task<ProdottiNuovoSingoloResponse> Nuovo(ProdottiNuovoSingoloRequest request)
        {
            return JsonConvert.DeserializeObject<ProdottiNuovoSingoloResponse>(await GenericPostAsync("/prodotti/nuovo", request));
        }

        // POST "/prodotti/importa"
        public async Task<GenericSuccessResponse> Importa(ProdottiNuovoListaRequest request)
        {
            return JsonConvert.DeserializeObject<GenericSuccessResponse>(await GenericPostAsync("/prodotti/importa", request));
        }

        // POST "/prodotti/modifica"
        public async Task<GenericSuccessResponse> Modifica(ProdottiModificaRequest request)
        {
            return JsonConvert.DeserializeObject<GenericSuccessResponse>(await GenericPostAsync("/prodotti/modifica", request));
        }

        // POST "/prodotti/elimina"
        public async Task<GenericSuccessResponse> Elimina(ProdottiEliminaRequest request)
        {
            return JsonConvert.DeserializeObject<GenericSuccessResponse>(await GenericPostAsync("/prodotti/elimina", request));
        }
    }
}
