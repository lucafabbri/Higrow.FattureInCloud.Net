using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class DocInfoResponse
    {
        public string ddt_numero_successivo { get; set; }
        public Dictionary<string,string> numerazioni { get; set; }
        public string default_id_template { get; set; }
        public string default_ddt_id_template { get; set; }
        public string default_ftacc_id_template { get; set; }
        public string default_cod_iva { get; set; }
        public string default_note { get; set; }
        public int default_cassa_previdenziale { get; set; }
        public int default_rivalsa_previdenziale { get; set; }
        public int default_ritenuta_acconto { get; set; }
        public int default_imponibile_ritenuta { get; set; }
        public int default_altra_ritenuta { get; set; }
        public bool default_prezzi_ivati { get; set; }
    }
}
