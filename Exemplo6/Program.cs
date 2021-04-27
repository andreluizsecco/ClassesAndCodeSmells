using System;

namespace Exemplo6
{
    class Program
    {
        static void Main(string[] args)
        {
            var relatorio = new Relatorio();

            //ERRADO
            relatorio.GerarRelatorio(true);

            //CERTO
            relatorio.GerarRelatorioComRodape();
        }
    }
}
