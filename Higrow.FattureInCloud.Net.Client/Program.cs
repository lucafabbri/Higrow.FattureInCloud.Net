using Higrow.FattureInCloud.Net.DTO;
using Higrow.FattureInCloud.Net.Services.v1;
using System;

namespace Higrow.FattureInCloud.Net.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            AcquistiService service = new AcquistiService();
            service.SetKeys("50535", "5c9db272d575fe75376bd1f382d6b66d");
            //var result = service.Lista(new AcquistiListaRequest()
            //{
            //    anno = 2019
            //}).Result;
            var result2 = service.Nuovo(new AcquistiNuovoRequest()
            {
                nome = "Test"
            }).Result;
            var result3 = service.Modifica(new AcquistiModificaRequest()
            {
                nome = "Test2",
                id=result2.new_id.ToString()
            }).Result;
            Console.ReadLine();
        }
    }
}
