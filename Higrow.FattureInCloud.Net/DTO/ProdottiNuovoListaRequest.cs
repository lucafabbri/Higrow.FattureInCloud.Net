using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class ProdottiNuovoListaRequest:JSONRequest
    {
        public List<ProdottiNuovoSingoloRequest> lista_prodotti { get; set; }
    }
}
