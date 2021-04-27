using System;

namespace Exemplo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var processo = new Processo();

            // ERRADO
            processo.DataCancelamento = DateTime.Now;

            // CORRETO
            processo.Cancelar();
        }
    }
}
