using System;

namespace Aula31WhatsApp
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        
        public Contato(string nome, string telefone)
        {
            this.Nome = nome;
            this.Telefone = telefone;

        }

        public Contato()
        {
        }

        internal void Cadastrar(Contato p1)
        {
            throw new NotImplementedException();
        }
    }
}