using Higrow.FattureInCloud.Net.DTO;
using Higrow.FattureInCloud.Net.Services.v1;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Test.v1
{
    public class MagazzinoUnitTest
    {
        MagazzinoService service;

        [SetUp]
        public void Setup()
        {
            service = new MagazzinoService();
            service.SetKeys("your_api_uid", "your_api_key");
        }

        [Test]
        public async Task TestLista()
        {
            var result = await service.Lista(new ArriviListaRequest()
            {
                anno = 2019
            });
            Assert.True(result.success);
        }

        [Test]
        public async Task TestDettagli()
        {
            var result = await service.Lista(new ArriviListaRequest()
            {
                anno = 2019
            });
            var result2 = await service.Dettagli(new ArriviDettagliRequest()
            {
                id = result.lista_documenti.FirstOrDefault()?.id
            });
            Assert.True(result2.success, await service.LastResponse?.Content.ReadAsStringAsync());
        }
    }
}
