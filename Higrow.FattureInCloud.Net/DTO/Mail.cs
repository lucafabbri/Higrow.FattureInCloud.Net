namespace Higrow.FattureInCloud.Net.DTO
{
    public class Mail
    {
        public string id { get; set; }
        public string stato_invio { get; set; }
        public string data { get; set; }
        public string mail_mittente { get; set; }
        public string mittente { get; set; }
        public string mail_destinatario { get; set; }
        public string destinatario { get; set; }
        public string oggetto { get; set; }
        public string messaggio { get; set; }
        public string mail_copia { get; set; }
        public string tipo { get; set; }
        public string stato_lettura { get; set; }
        public string data_lettura { get; set; }
        public string allegati { get; set; }
    }
}