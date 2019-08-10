using System.Collections.Generic;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class CorrispettiviDetailed
    {
        public string id { get; set; }
        public string tipo { get; set; }
        public string data { get; set; }
        public string protocollo { get; set; }
        public string desc { get; set; }
        public int importo_netto { get; set; }
        public int importo_lordo { get; set; }
        public string centro_ricavo { get; set; }
        public string metodo { get; set; }
        public bool importi_ivati { get; set; }
        public List<CorrispettiviRiga> lista_righe { get; set; }
    }
}