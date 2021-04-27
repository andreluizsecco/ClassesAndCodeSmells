using System;

namespace Exemplo5
{
    public class LivroFisico : Livro
    {
        public LivroFisico(string titulo)
            : base(titulo) { }

        public override void Comprar()
        {
            //Implementação
            Console.WriteLine("Seu livro será enviado para sua casa");
        }
    }
}