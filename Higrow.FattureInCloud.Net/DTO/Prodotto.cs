namespace Higrow.FattureInCloud.Net.DTO
{
    public class Prodotto
    {
        public string id { get; set; }
        public string cod { get; set; }
        public string nome { get; set; }
        public string desc { get; set; }
        public bool prezzo_ivato { get; set; }
        public string prezzo_netto { get; set; }
        public string prezzo_lordo { get; set; }
        public string costo { get; set; }
        public int valore_iva { get; set; }
        public string desc_iva { get; set; }
        public string um { get; set; }
        public string categoria { get; set; }
        public string note { get; set; }
        public bool magazzino { get; set; }
        public string giacenza_iniziale { get; set; }
        public string giacenza { get; set; }
    }
}