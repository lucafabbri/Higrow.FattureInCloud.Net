namespace Higrow.FattureInCloud.Net.DTO
{
    public class AcquistiNuovoArticolo
    {
        public string id { get; set; }
        public string codice { get; set; }
        public string nome { get; set; }
        public string um { get; set; }
        public int quantita { get; set; }
        public double prezzo_netto { get; set; }
        public double cod_iva { get; set; }
        public string categoria { get; set; }
        public int ordine { get; set; }
        public bool magazzino { get; set; }
    }
}