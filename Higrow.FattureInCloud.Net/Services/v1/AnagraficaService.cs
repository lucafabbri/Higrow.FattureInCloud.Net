using Higrow.FattureInCloud.Net.DTO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Services.v1
{
    public class AnagraficaService:BaseService
    {
        public AnagraficaService() : base() { }

        // POST "/{soggetto}/lista"
        public async Task<AnagraficaListaResponse> Lista(string soggetto, AnagraficaListaRequest request)
        {
            return JsonConvert.DeserializeObject<AnagraficaListaResponse>(await GenericPostAsync("/" + soggetto + "/lista", request));
        }

        // POST "/{soggetto}/nuovo"
        public async Task<AnagraficaNuovoSingoloResponse> Nuovo(string soggetto, AnagraficaNuovoSingoloRequest request)
        {
            return JsonConvert.DeserializeObject<AnagraficaNuovoSingoloResponse>(await GenericPostAsync("/" + soggetto + "/nuovo", request));
        }

        // POST "/{soggetto}/importa"
        public async Task<GenericSuccessResponse> Importa(string soggetto, AnagraficaNuovoListaRequest request)
        {
            return JsonConvert.DeserializeObject<GenericSuccessResponse>(await GenericPostAsync("/" + soggetto + "/importa", request));
        }

        // POST "/{soggetto}/modifica"
        public async Task<GenericSuccessResponse> Modifica(string soggetto, AnagraficaModificaRequest request)
        {
            return JsonConvert.DeserializeObject<GenericSuccessResponse>(await GenericPostAsync("/" + soggetto + "/modifica", request));
        }

        // POST "/{soggetto}/elimina"
        public async Task<GenericSuccessResponse> Elimina(string soggetto, AnagraficaEliminaRequest request)
        {
            return JsonConvert.DeserializeObject<GenericSuccessResponse>(await GenericPostAsync("/" + soggetto + "/elimina", request));
        }
    }
}
