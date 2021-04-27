using System;

namespace Exemplo1
{
    public class Processo
    {
        public int Id { get; set; }
        public DateTime? DataCancelamento { get; private set; }

        public void Cancelar()
        {
            DataCancelamento = DateTime.Now;
        }
    }
}