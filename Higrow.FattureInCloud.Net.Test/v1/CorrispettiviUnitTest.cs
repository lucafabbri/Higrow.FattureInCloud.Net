using Higrow.FattureInCloud.Net.DTO;
using Higrow.FattureInCloud.Net.Services.v1;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Test.v1
{
    public class CorrispettiviUnitTest
    {
        CorrispettiviService service;

        [SetUp]
        public void Setup()
        {
            service = new CorrispettiviService();
            service.SetKeys("your_api_uid", "your_api_key");
        }

        [Test]
        public async Task TestLista()
        {
            var result = await service.Lista(new CorrispettiviListaRequest()
            {
                anno = 2019
            });
            Assert.True(result.success);
        }

        [Test]
        public async Task TestNuovoModificaElimina()
        {
            var result = await service.Nuovo(new CorrispettiviNuovoRequest()
            {
                data = DateTime.Now.ToString("dd/MM/yyyy"),
                centro_ricavo ="test",
                desc ="test",
                lista_righe = new System.Collections.Generic.List<CorrispettiviNuovoRiga>()
                {
                    new CorrispettiviNuovoRiga()
                    {
                        categoria = "test",
                        cod_iva = 0,
                        importo = 22.5
                    }
                },
                metodo = "test",
                tipo = "ricevute"
            });
            Assert.True(result.success, "NUOVO - "+await service.LastResponse.Content.ReadAsStringAsync());

            var result2 = await service.Modifica(new CorrispettiviModificaRequest()
            {
                id = result.new_id.ToString(),  
                desc = "description",
                lista_righe = new System.Collections.Generic.List<CorrispettiviNuovoRiga>()
                {
                    new CorrispettiviNuovoRiga()
                    {
                        categoria = "test",
                        cod_iva = 0,
                        importo = 22.5
                    }
                },
            });
            Assert.True(result2.success, "MODIFICA - " + await service.LastResponse.Content.ReadAsStringAsync());

            var result3 = await service.Elimina(new CorrispettiviEliminaRequest()
            {
                id = result2.new_id.ToString()
            });
            Assert.True(result3.success, "ELIMINA - " + await service.LastResponse.Content.ReadAsStringAsync());
        }
    }
}
