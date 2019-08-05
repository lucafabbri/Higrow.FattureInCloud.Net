using Higrow.FattureInCloud.Net.DTO;
using Higrow.FattureInCloud.Net.Services.v1;
using Higrow.FattureInCloud.Net.Sets;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Test.v1
{
    public class AnagraficaUnitTest
    {
        AnagraficaService service;

        [SetUp]
        public void Setup()
        {
            service = new AnagraficaService();
            service.SetKeys("your_api_uid","your_api_key");
        }

        [Test]
        public async Task TestLista()
        {
            var result = await service.Lista(Soggetto.CLIENTI, new AnagraficaListaRequest()
            {

            });
            Assert.True(result.success);
        }

        [Test]
        public async Task TestImporta()
        {
            var result = await service.Importa(Soggetto.CLIENTI, new AnagraficaNuovoListaRequest()
            {
                lista_soggetti = new List<AnagraficaNuovoSingoloRequest>()
                {
                    new AnagraficaNuovoSingoloRequest
                    {
                        nome = "Importato"
                    }
                }
            });
            Assert.True(result.success);
        }

        [Test]
        public async Task TestNuovoModificaElimina()
        {
            var result = await service.Nuovo(Soggetto.CLIENTI, new AnagraficaNuovoSingoloRequest()
            {
                nome = "Test"
            });
            Assert.True(result.success);

            var result2 = await service.Modifica(Soggetto.CLIENTI, new AnagraficaModificaRequest()
            {
                nome = "Test2",
                id = result.id.ToString()
            });
            Assert.True(result2.success);

            var result3 = await service.Elimina(Soggetto.CLIENTI, new AnagraficaEliminaRequest()
            {
                id = result.id.ToString()
            });
            Assert.True(result3.success);
        }
    }
}
