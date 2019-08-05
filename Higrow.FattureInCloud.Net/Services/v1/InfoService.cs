using Higrow.FattureInCloud.Net.DTO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Services.v1
{
    public class InfoService:BaseService
    {
        public InfoService() : base() { }

        // POST "/info/account"
        public async Task<InfoListaResponse> Lista(InfoListaRequest request)
        {
            return JsonConvert.DeserializeObject<InfoListaResponse>(await GenericPostAsync("/acquisti/lista", request));
        }
    }
}
