using Higrow.FattureInCloud.Net.Constants;
using Higrow.FattureInCloud.Net.DTO;
using Higrow.FattureInCloud.Net.Services.v1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Test.v1
{
    public class DocumentiUnitTest
    {
        DocumentiService service;

        [SetUp]
        public void Setup()
        {
            service = new DocumentiService();
            service.SetKeys("your_api_uid","your_api_key");
        }

        [Test]
        public async Task TestLista()
        {
            var result = await service.Lista(Documento.FATTURE, new DocListaRequest()
            {
                anno = 2019
            });
            Assert.True(result.success);
        }

        [Test]
        public async Task TestDettagli()
        {
            var result = await service.Lista(Documento.FATTURE, new DocListaRequest()
            {
                anno = 2019
            });
            var result2 = await service.Dettagli(Documento.FATTURE, new DocDettagliRequest()
            {
                id = result.lista_documenti.FirstOrDefault().id,
                token = result.lista_documenti.FirstOrDefault().token
            });
            Assert.True(result2.success);
        }

        [Test]
        public async Task TestNuovoModificaElimina()
        {
            var result = await service.Nuovo(Documento.FATTURE, new DocNuovoRequest()
            {
                nome = "Test",
                lista_articoli = new List<DocNuovoArticolo>()
                {
                    new DocNuovoArticolo()
                    {
                        nome = "Articolo"
                    }
                }
            });
            Assert.True(result.success);

            var result2 = await service.Modifica(Documento.FATTURE, new DocModificaRequest()
            {
                nome = "Test2",
                id = result.new_id.ToString(),
                lista_articoli = new List<DocNuovoArticolo>()
                {
                    new DocNuovoArticolo()
                    {
                        nome = "Articolo2"
                    }
                }
            });
            Assert.True(result2.success);

            var result3 = await service.Elimina(Documento.FATTURE, new DocEliminaRequest()
            {
                id = result2.new_id.ToString()
            });
            Assert.True(result3.success);
        }

        [Test]
        public async Task TestInfo()
        {
            var result = await service.Info(Documento.FATTURE, new DocInfoRequest()
            {
                anno = 2019
            });
            Assert.True(result!=null);
        }
    }
}
