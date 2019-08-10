using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class CorrispettiviNuovoRequest: JSONRequest
    {
        public string tipo { get; set; }
        public string data { get; set; }
        public bool protocollo_auto { get; set; }
        public string protocollo { get; set; }
        public string desc { get; set; }
        public string centro_ricavo { get; set; }
        public string metodo { get; set; }
        public bool importi_ivati { get; set; }
        public List<CorrispettiviNuovoRiga> lista_righe { get; set; }
    }
}
