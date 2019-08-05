using Higrow.FattureInCloud.Net.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Services
{
    public class BaseService
    {
        protected string _api_uid;
        protected string _api_key;
        protected HttpClient _client;

        public HttpResponseMessage LastResponse;

        protected string _baseAddress = "https://api.fattureincloud.it:443/v1";
        public BaseService()
        {
        }

        public void SetKeys(string apiuid, string apikey)
        {
            _api_uid = apiuid;
            _api_key = apikey;
        }

        protected async Task<string> GenericPostAsync(string endpoint, IJSONRequest request)
        {
            string result = string.Empty;
            using (_client = new HttpClient())
            {
                Debug.WriteLine("Client created");
                _client.DefaultRequestHeaders
                      .Accept
                      .Add(new MediaTypeWithQualityHeaderValue("application/json"));
                request.api_key = _api_key;
                request.api_uid = _api_uid;
                var body = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                Debug.WriteLine("Sending request");
                Debug.WriteLine(await body.ReadAsStringAsync());
                Debug.WriteLine("...");
                LastResponse = await _client.PostAsync(_baseAddress + endpoint, body);
                Debug.WriteLine("Response received");
                if (LastResponse.IsSuccessStatusCode)
                {
                    result =  await LastResponse.Content.ReadAsStringAsync();
                    Debug.WriteLine(result);
                }
                else
                {
                    Debug.WriteLine("Response error");
                    Debug.WriteLine(await LastResponse.Content.ReadAsStringAsync());
                }
            }
            return result;
        }
    }
}
