namespace Higrow.FattureInCloud.Net.DTO
{
    public class MailListaRequest:JSONRequest
    {
        public MailListaRequest()
        {
            pagina = 1;
        }
        public string filtro { get; set; }
        public string destinatario { get; set; }
        public string mittente { get; set; }
        public string stato { get; set; }
        public string data_inizio { get; set; }
        public string data_fine { get; set; }
        public int pagina { get; set; }
    }
}