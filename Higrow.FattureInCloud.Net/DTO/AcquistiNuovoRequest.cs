using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class AcquistiNuovoRequest:JSONRequest
    {
        public AcquistiNuovoRequest()
        {
            tipo = "spesa";
            ammortamento = 1;
            salva_anagrafica = false;
        }
        public string tipo { get; set; }
        public string id_fornitore { get; set; }
        public string nome { get; set; }
        public string piva { get; set; }
        public string cf { get; set; }
        public bool autocompila_anagrafica { get; set; }
        public bool salva_anagrafica { get; set; }
        public string data { get; set; }
        public string descrizione { get; set; }
        public string categoria { get; set; }
        public double importo_netto { get; set; }
        public double importo_iva { get; set; }
        public string valuta { get; set; }
        public double valuta_cambio { get; set; }
        public double ritenuta_acconto { get; set; }
        public double ritenuta_previdenziale { get; set; }
        public double deducibilita_tasse { get; set; }
        public double detraibilita_iva { get; set; }
        public int ammortamento { get; set; }
        public string centro_costo { get; set; }
        public string numero_fattura { get; set; }
        public List<DocNuovoPagamento> lista_pagamenti { get; set; }
        public List<AcquistiNuovoArticolo> lista_articoli { get; set; }
    }
}
