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
            service.SetKeys("50535", "5c9db272d575fe75376bd1f382d6b66d");
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
