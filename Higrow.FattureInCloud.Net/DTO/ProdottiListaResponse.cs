using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class ProdottiListaResponse:GenericSuccessResponse
    {
        public List<Prodotto> lista_prodotti { get; set; }
        public int pagina_corrente { get; set; }
        public int numero_pagine { get; set; }
    }
}
