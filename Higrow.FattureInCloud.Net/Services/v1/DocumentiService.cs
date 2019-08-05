using Higrow.FattureInCloud.Net.DTO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Services.v1
{
    public class DocumentiService:BaseService
    {
        public DocumentiService() : base() { }

        // POST "/{tipo-doc}/lista"
        public async Task<DocListaResponse> Lista(string documento, DocListaRequest request)
        {
            return JsonConvert.DeserializeObject<DocListaResponse>(await GenericPostAsync("/" + documento + "/lista", request));
        }

        // POST "/{tipo-doc}/dettagli"
        public async Task<DocDettagliResponse> Dettagli(string documento, DocDettagliRequest request)
        {
            return JsonConvert.DeserializeObject<DocDettagliResponse>(await GenericPostAsync("/" + documento + "/dettagli", request));
        }

        // POST "/{tipo-doc}/nuovo"
        public async Task<DocNuovoResponse> Nuovo(string documento, DocNuovoRequest request)
        {
            return JsonConvert.DeserializeObject<DocNuovoResponse>(await GenericPostAsync("/" + documento + "/nuovo", request));
        }

        // POST "/{tipo-doc}/modifica"
        public async Task<DocNuovoResponse> Modifica(string documento, DocModificaRequest request)
        {
            return JsonConvert.DeserializeObject<DocNuovoResponse>(await GenericPostAsync("/" + documento + "/modifica", request));
        }

        // POST "/{tipo-doc}/elimina"
        public async Task<GenericSuccessResponse> Elimina(string documento, DocEliminaRequest request)
        {
            return JsonConvert.DeserializeObject<GenericSuccessResponse>(await GenericPostAsync("/" + documento + "/elimina", request));
        }

        // POST "/{tipo-doc}/info"
        public async Task<DocInfoResponse> Info(string documento, DocInfoRequest request)
        {
            return JsonConvert.DeserializeObject<DocInfoResponse>(await GenericPostAsync("/" + documento + "/info", request));
        }

        // POST "/{tipo-doc}/infomail"
        public async Task<DocInfomailResponse> InfoMail(string documento, DocInfomailRequest request)
        {
            return JsonConvert.DeserializeObject<DocInfomailResponse>(await GenericPostAsync("/" + documento + "/infomail", request));
        }

        // POST "/{tipo-doc}/inviamail"
        public async Task<GenericSuccessResponse> InviaMail(string documento, DocInviamailRequest request)
        {
            return JsonConvert.DeserializeObject<GenericSuccessResponse>(await GenericPostAsync("/" + documento + "/inviamail", request));
        }
    }
}
