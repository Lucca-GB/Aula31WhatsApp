namespace Aula31WhatsApp
{
    public class Mensagem
    {
        public string Texto {get; set;}
        public Contato Destinatario {get; set;}
        public string Enviar(Contato contato){
            
            return $"Sua mensagem: '{Texto}' foi enviada para: {Destinatario.Nome}";
        }
        
    }
}