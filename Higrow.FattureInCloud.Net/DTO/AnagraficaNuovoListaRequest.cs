using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class AnagraficaNuovoListaRequest : JSONRequest
    {
        public List<AnagraficaNuovoSingoloRequest> lista_soggetti { get; set; }
    }
}
