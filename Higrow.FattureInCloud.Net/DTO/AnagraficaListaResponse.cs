using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class AnagraficaListaResponse:GenericSuccessResponse
    {
        public List<AnagraficaCliente> lista_clienti { get; set; }
        public List<AnagraficaFornitore> lista_fornitori { get; set; }
        public int pagina_corrente { get; set; }
        public int numero_pagine { get; set; }
    }
}
