using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class InfoListaResponse:GenericSuccessResponse
    {
        public string nome { get; set; }
        public int durata_licenza { get; set; }
        public string tipo_licenza { get; set; }
        public List<InfoValuta> lista_valute { get; set; }
        public List<InfoIva> lista_iva { get; set; }
        public List<string> lista_paesi { get; set; }
        public List<InfoTemplate> lista_template { get; set; }
        public List<InfoTemplate> lista_template_ddt { get; set; }
        public List<InfoTemplate> lista_template_ddt_ftacc { get; set; }
        public List<InfoConto> lista_conti { get; set; }
        public List<InfoMetodo> lista_metodi_pagamento { get; set; }
    }
}
