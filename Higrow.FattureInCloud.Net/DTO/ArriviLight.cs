namespace Higrow.FattureInCloud.Net.DTO
{
    public class ArriviLight
    {
        public string id { get; set; }
        public string id_fornitore { get; set; }
        public string nome { get; set; }
        public string data { get; set; }
        public string descrizione { get; set; }
        public double importo_netto { get; set; }
        public double importo_iva { get; set; }
        public double importo_totale { get; set; }
        public string valuta { get; set; }
        public double valuta_cambio { get; set; }
        public object link_allegato { get; set; }
    }
}