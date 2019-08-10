using Higrow.FattureInCloud.Net.DTO;
using Higrow.FattureInCloud.Net.Services.v1;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Test.v1
{
    public class MailUnitTest
    {
        MailService service;

        [SetUp]
        public void Setup()
        {
            service = new MailService();
            service.SetKeys("your_api_uid", "your_api_key");
        }

        [Test]
        public async Task TestLista()
        {
            var result = await service.Lista(new MailListaRequest()
            {
            });
            Assert.True(result.success, await service.LastResponse?.Content.ReadAsStringAsync());
        }
    }
}
