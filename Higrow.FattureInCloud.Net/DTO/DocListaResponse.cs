using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class DocListaResponse:GenericSuccessResponse
    {
        public List<DocLight> lista_documenti { get; set; }
        public int pagina_corrente { get; set; }
        public int numero_pagine { get; set; }
        public int numero_risultati { get; set; }
        public int risultati_per_pagina { get; set; }
    }
}
