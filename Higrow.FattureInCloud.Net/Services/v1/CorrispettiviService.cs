using Higrow.FattureInCloud.Net.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Services.v1
{
    public class CorrispettiviService:BaseService
    {
        public CorrispettiviService() : base() { }

        // POST "/corrispettivi/lista"
        public async Task<CorrispettiviListaResponse> Lista(CorrispettiviListaRequest request)
        {
            return JsonConvert.DeserializeObject<CorrispettiviListaResponse>(await GenericPostAsync("/corrispettivi/lista", request));
        }

        // POST "/corrispettivi/nuovo"
        public async Task<CorrispettiviNuovoResponse> Nuovo(CorrispettiviNuovoRequest request)
        {
            return JsonConvert.DeserializeObject<CorrispettiviNuovoResponse>(await GenericPostAsync("/corrispettivi/nuovo", request));
        }

        // POST "/corrispettivi/modifica"
        public async Task<CorrispettiviNuovoResponse> Modifica(CorrispettiviModificaRequest request)
        {
            return JsonConvert.DeserializeObject<CorrispettiviNuovoResponse>(await GenericPostAsync("/corrispettivi/modifica", request));
        }

        // POST "/corrispettivi/elimina"
        public async Task<GenericSuccessResponse> Elimina(CorrispettiviEliminaRequest request)
        {
            return JsonConvert.DeserializeObject<GenericSuccessResponse>(await GenericPostAsync("/corrispettivi/elimina", request));
        }
    }
}
