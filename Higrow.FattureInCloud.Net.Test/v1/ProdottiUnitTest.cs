using Higrow.FattureInCloud.Net.DTO;
using Higrow.FattureInCloud.Net.Services.v1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Test.v1
{
    public class ProdottiUnitTest
    {
        ProdottiService service;

        [SetUp]
        public void Setup()
        {
            service = new ProdottiService();
            service.SetKeys("50535", "5c9db272d575fe75376bd1f382d6b66d");
        }

        [Test]
        public async Task TestLista()
        {
            var result = await service.Lista(new ProdottiListaRequest()
            {
                
            });
            Assert.True(result.success);
        }

        [Test]
        public async Task TestImporta()
        {
            var result = await service.Importa(new ProdottiNuovoListaRequest()
            {
                lista_prodotti = new List<ProdottiNuovoSingoloRequest>()
                {
                    new ProdottiNuovoSingoloRequest()
                    {
                        nome="Test"
                    }
                }
            });
            Assert.True(result.success);
        }

        [Test]
        public async Task TestNuovoModificaElimina()
        {
            var result = await service.Nuovo(new ProdottiNuovoSingoloRequest()
            {
                nome = "Test"
            });
            Assert.True(result.success);

            var result2 = await service.Modifica(new ProdottiModificaRequest()
            {
                nome = "Test2",
                id = result.id.ToString()
            });
            Assert.True(result2.success);

            var result3 = await service.Elimina(new ProdottiEliminaRequest()
            {
                id = result.id.ToString()
            });
            Assert.True(result3.success);
        }
    }
}
