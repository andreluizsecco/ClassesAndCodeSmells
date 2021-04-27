namespace Exemplo5
{
    // public class Livro
    // {
    //     public string Titulo { get; set; }
    //     public LivroTipo Tipo { get; set; }
        
    //     public Livro(string titulo, LivroTipo tipo)
    //     {
    //         Titulo = titulo;
    //         Tipo = tipo;
    //     }

    //     public enum LivroTipo
    //     {
    //         Fisico = 1,
    //         Digital = 2
    //     }
    // }

    public abstract class Livro
    {
        public string Titulo { get; set; }
        
        public Livro(string titulo)
        {
            Titulo = titulo;
        }

        public abstract void Comprar();
    }
}