using System;

namespace Exemplo7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dataVencimento = DateTime.Today;
            var lancamento = new Lancamento(dataVencimento);

            //ERRADO
            if (dataVencimento.Day >= 10 && dataVencimento.Day <= 20)
            {
                //Implementação
            }
            
            //CORRETO
            if (lancamento.PermiteLancamento())
            {
                //Implementação
            }
        }
    }
}
