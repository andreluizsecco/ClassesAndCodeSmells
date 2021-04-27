namespace Exemplo4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var processo = new Processo();

            
            if (!processo.PossuiBloqueioAlteracao())
            {
                //Implementação
            }

            if (processo.PermiteAlteracao())
            {
                //Implementação
            }
            
        }
    }
}
