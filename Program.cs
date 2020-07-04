using System.Collections.Generic;

namespace Aula31WhatsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda contacts = new Agenda();
            Contato p1 = new Contato();
            
            p1.Nome = "Tony";
            p1.Telefone = "(21) 2623-2346";




            Mensagem texto = new Mensagem();
            texto.Texto = "Olá!";
            texto.Destinatario = p1;


            contacts.Cadastrar(p1);
            contacts.Excluir("linha");
            System.Console.WriteLine(texto.Enviar(texto.Destinatario));       
        }
    }
}
