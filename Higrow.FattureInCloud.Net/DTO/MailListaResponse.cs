using System.Collections.Generic;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class MailListaResponse:GenericSuccessResponse
    {
        public List<Mail> lista_mail { get; set; }
        public int pagina_corrente { get; set; }
        public int numero_pagine { get; set; }
    }
}