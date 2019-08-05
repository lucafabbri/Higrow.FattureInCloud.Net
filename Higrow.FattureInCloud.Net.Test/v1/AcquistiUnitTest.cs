using Higrow.FattureInCloud.Net.DTO;
using Higrow.FattureInCloud.Net.Services.v1;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Test.v1
{
    public class AcquistiUnitTest
    {
        AcquistiService service;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task TestLista()
        {
            service = new AcquistiService();
            service.SetKeys("your_api_uid","your_api_key");
            var result = await service.Lista(new AcquistiListaRequest()
            {
                anno = 2019
            });
            Assert.True(result.success);
        }

        [Test]
        public async Task TestDettagli()
        {
            service = new AcquistiService();
            service.SetKeys("your_api_uid","your_api_key");
            var result = await service.Lista(new AcquistiListaRequest()
            {
                anno = 2019
            });
            var result2 = await service.Dettagli(new AcquistiDettagliRequest()
            {
                id = result.lista_documenti.FirstOrDefault().id
            });
            Assert.True(result2.success);
        }

        [Test]
        public async Task TestNuovoModificaElimina()
        {
            service = new AcquistiService();
            service.SetKeys("your_api_uid","your_api_key");
            var result = await service.Nuovo(new AcquistiNuovoRequest()
            {
                nome = "Test"
            });
            Assert.True(result.success);

            var result2 = await service.Modifica(new AcquistiModificaRequest()
            {
                nome = "Test2",
                id = result.new_id.ToString()
            });
            Assert.True(result2.success);

            var result3 = await service.Elimina(new AcquistiEliminaRequest()
            {
                id = result2.new_id.ToString()
            });
            Assert.True(result3.success);
        }
    }
}