using System;

namespace Exemplo4
{
    public class Processo
    {
        public int Id { get; set; }
        public DateTime? DataBloqueio { get; set; }
        
        
        public bool PermiteAlteracao()
        {
            return DataBloqueio == null;
        }

        public bool PossuiBloqueioAlteracao()
        {
            return DataBloqueio != null;
        }
    }
}