namespace Higrow.FattureInCloud.Net.DTO
{
    public class DocLight
    {
        public string id { get; set; }
        public string token { get; set; }
        public string tipo { get; set; }
        public string id_cliente { get; set; }
        public string id_fornitore { get; set; }
        public string nome { get; set; }
        public string numero { get; set; }
        public string data { get; set; }
        public double importo_netto { get; set; }
        public double importo_totale { get; set; }
        public string valuta { get; set; }
        public double valuta_cambio { get; set; }
        public string prossima_scadenza { get; set; }
        public bool ddt { get; set; }
        public bool ftacc { get; set; }
        public string oggetto_visibile { get; set; }
        public string oggetto_interno { get; set; }
        public string link_doc { get; set; }
        public string ddt_numero { get; set; }
        public string ddt_data { get; set; }
        public bool bloccato { get; set; }
        public bool PA { get; set; }
        public string PA_tipo_cliente { get; set; }
    }
}