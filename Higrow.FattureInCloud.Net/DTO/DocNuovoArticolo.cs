namespace Higrow.FattureInCloud.Net.DTO
{
    public class DocNuovoArticolo
    {
        public DocNuovoArticolo()
        {
            cod_iva = 0; //this is the first iva code 0 == 22%
            tassabile = true; //set false to keep item out of iva calculation
        }
        public string id { get; set; }
        public string codice { get; set; }
        public string nome { get; set; }
        public string um { get; set; }
        public int quantita { get; set; }
        public string descrizione { get; set; }
        public string categoria { get; set; }
        public int prezzo_netto { get; set; }
        public int prezzo_lordo { get; set; }
        public int cod_iva { get; set; }
        public bool tassabile { get; set; }
        public int sconto { get; set; }
        public bool applica_ra_contributi { get; set; }
        public int ordine { get; set; }
        public int sconto_rosso { get; set; }
        public bool in_ddt { get; set; }
        public bool magazzino { get; set; }
    }
}