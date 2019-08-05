using Higrow.FattureInCloud.Net.DTO;
using Higrow.FattureInCloud.Net.Services.v1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Higrow.FattureInCloud.Net.Test.v1
{
    public class InfoUnitTest
    {
        InfoService service;

        [SetUp]
        public void Setup()
        {
            service = new InfoService();
            service.SetKeys("your_api_uid","your_api_key");
        }

        [Test]
        public async Task TestLista()
        {
            var result = await service.Lista( new InfoListaRequest()
            {
                anno_competenza = 2019
            });
            Assert.True(result.success);
        }
    }
}
