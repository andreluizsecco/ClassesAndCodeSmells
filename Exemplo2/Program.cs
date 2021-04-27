using System;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var processo = new Processo();
            
            //ERRADO
            processo.AlterParaModulo('C');

            //CERTO
            processo.AlterParaModulo(Modulos.Contabilidade);

            processo.Cancelar();
        }
    }
}
