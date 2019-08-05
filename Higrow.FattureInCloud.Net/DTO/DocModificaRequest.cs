using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class DocModificaRequest:JSONRequest
    {
        public string id { get; set; }
        public string token { get; set; }
        public string id_cliente { get; set; }
        public string id_fornitore { get; set; }
        public string nome { get; set; }
        public string indirizzo_via { get; set; }
        public string indirizzo_cap { get; set; }
        public string indirizzo_citta { get; set; }
        public string indirizzo_provincia { get; set; }
        public string indirizzo_extra { get; set; }
        public string paese { get; set; }
        public string paese_iso { get; set; }
        public string lingua { get; set; }
        public string piva { get; set; }
        public string cf { get; set; }
        public bool autocompila_anagrafica { get; set; }
        public bool salva_anagrafica { get; set; }
        public string numero { get; set; }
        public string data { get; set; }
        public string valuta { get; set; }
        public int valuta_cambio { get; set; }
        public bool prezzi_ivati { get; set; }
        public int rivalsa { get; set; }
        public int cassa { get; set; }
        public int rit_acconto { get; set; }
        public int imponibile_ritenuta { get; set; }
        public int rit_altra { get; set; }
        public int marca_bollo { get; set; }
        public string oggetto_visibile { get; set; }
        public string oggetto_interno { get; set; }
        public string centro_ricavo { get; set; }
        public string centro_costo { get; set; }
        public string note { get; set; }
        public bool nascondi_scadenza { get; set; }
        public bool ddt { get; set; }
        public bool ftacc { get; set; }
        public string id_template { get; set; }
        public string ddt_id_template { get; set; }
        public string ftacc_id_template { get; set; }
        public bool mostra_info_pagamento { get; set; }
        public string metodo_pagamento { get; set; }
        public string metodo_titoloN { get; set; }
        public string metodo_descN { get; set; }
        public string mostra_totali { get; set; }
        public bool mostra_bottone_paypal { get; set; }
        public bool mostra_bottone_bonifico { get; set; }
        public bool mostra_bottone_notifica { get; set; }
        public List<DocNuovoArticolo> lista_articoli { get; set; }
        public List<DocNuovoPagamento> lista_pagamenti { get; set; }
        public string ddt_numero { get; set; }
        public string ddt_data { get; set; }
        public string ddt_colli { get; set; }
        public string ddt_peso { get; set; }
        public string ddt_causale { get; set; }
        public string ddt_luogo { get; set; }
        public string ddt_trasportatore { get; set; }
        public string ddt_annotazioni { get; set; }
        public bool PA { get; set; }
        public string PA_tipo_cliente { get; set; }
        public string PA_tipo { get; set; }
        public string PA_numero { get; set; }
        public string PA_data { get; set; }
        public string PA_cup { get; set; }
        public string PA_cig { get; set; }
        public string PA_codice { get; set; }
        public string PA_pec { get; set; }
        public string PA_esigibilita { get; set; }
        public string PA_modalita_pagamento { get; set; }
        public string PA_istituto_credito { get; set; }
        public string PA_iban { get; set; }
        public string PA_beneficiario { get; set; }
        public DocNuovoExtraAnagrafica extra_anagrafica { get; set; }
        public bool split_payment { get; set; }
    }
}
