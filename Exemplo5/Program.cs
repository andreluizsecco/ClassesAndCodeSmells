using System;

namespace Exemplo5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ERRADO
            var livro = new Livro("Livro1", Livro.LivroTipo.Fisico);

            if (livro.Tipo == Livro.LivroTipo.Fisico)
            {
                Console.WriteLine("Seu livro será enviado para sua casa");
            }
            else
            {
                Console.WriteLine("Seu livro será enviado para seu e-mail");
            }

            switch (livro.Tipo)
            {
                case Livro.LivroTipo.Fisico:
                    Console.WriteLine("Seu livro será enviado para sua casa");
                    break;
                case Livro.LivroTipo.Digital:
                    Console.WriteLine("Seu livro será enviado para seu e-mail");
                    break;
            }

            //CORRETO
            Livro livroCorreto = new LivroFisico("Livro1");
            livroCorreto.Comprar();
        }
    }
}
