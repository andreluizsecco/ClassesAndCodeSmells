using System;

namespace Exemplo5
{
    public class LivroDigital : Livro
    {
        public LivroDigital(string titulo)
            : base(titulo) { }

        public override void Comprar()
        {
            //Implementação
            Console.WriteLine("Seu livro será enviado para seu e-mail");
        }
    }
}