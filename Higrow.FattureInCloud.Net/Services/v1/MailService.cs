using Higrow.FattureInCloud.Net.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Services.v1
{
    public class MailService:BaseService
    {
        public MailService() : base() { }

        // POST "/arrivimerci/lista"
        public async Task<MailListaResponse> Lista(MailListaRequest request)
        {
            return JsonConvert.DeserializeObject<MailListaResponse>(await GenericPostAsync("/mail/lista", request));
        }
    }
}
