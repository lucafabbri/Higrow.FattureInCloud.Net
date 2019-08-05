using System.Collections.Generic;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class AcquistiDetailed
    {
        public string id { get; set; }
        public string tipo { get; set; }
        public string id_fornitore { get; set; }
        public string nome { get; set; }
        public string data { get; set; }
        public string descrizione { get; set; }
        public string categoria { get; set; }
        public double importo_netto { get; set; }
        public double importo_iva { get; set; }
        public double importo_totale { get; set; }
        public string valuta { get; set; }
        public double valuta_cambio { get; set; }
        public object link_allegato { get; set; }
        public double ritenuta_acconto { get; set; }
        public double ritenuta_previdenziale { get; set; }
        public double deducibilita_tasse { get; set; }
        public double detraibilita_iva { get; set; }
        public double ammortamento { get; set; }
        public string centro_costo { get; set; }
        public string numero_fattura { get; set; }
        public string prossima_scadenza { get; set; }
        public List<DocPagamento> lista_pagamenti { get; set; }
        public List<AcquistiArticolo> lista_articoli { get; set; }
    }
}