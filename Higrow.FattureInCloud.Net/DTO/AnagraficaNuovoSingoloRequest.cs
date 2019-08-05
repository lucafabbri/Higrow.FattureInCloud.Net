using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.FattureInCloud.Net.DTO
{
    public class AnagraficaNuovoSingoloRequest:JSONRequest
    {
        public string nome { get; set; }
        public string referente { get; set; }
        public string indirizzo_via { get; set; }
        public string indirizzo_cap { get; set; }
        public string indirizzo_citta { get; set; }
        public string indirizzo_provincia { get; set; }
        public string indirizzo_extra { get; set; }
        public string paese { get; set; }
        public string paese_iso { get; set; }
        public string mail { get; set; }
        public string tel { get; set; }
        public string fax { get; set; }
        public string piva { get; set; }
        public string cf { get; set; }
        public string termini_pagamento { get; set; }
        public bool pagamento_fine_mese { get; set; }
        public int cod_iva_default { get; set; }
        public string extra { get; set; }
        public bool PA { get; set; }
        public string PA_codice { get; set; }
    }
}
