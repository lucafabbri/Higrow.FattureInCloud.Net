namespace Higrow.FattureInCloud.Net.DTO
{
    public class DocArticolo
    {
        public string id { get; set; }
        public string codice { get; set; }
        public string nome { get; set; }
        public string um { get; set; }
        public int quantita { get; set; }
        public string descrizione { get; set; }
        public string categoria { get; set; }
        public double prezzo_netto { get; set; }
        public double prezzo_lordo { get; set; }
        public double valore_iva { get; set; }
        public string desc_iva { get; set; }
        public bool tassabile { get; set; }
        public double sconto { get; set; }
        public bool applica_ra_contributi { get; set; }
        public int ordine { get; set; }
        public string sconto_rosso { get; set; }
        public bool in_ddt { get; set; }
        public bool magazzino { get; set; }
    }
}