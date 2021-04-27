using System;

namespace Exemplo2
{
    public class Processo
    {
        public int Id { get; set; }
        private int Situacao { get; set; }
        public char ModuloERP { get; set; }
        private DateTime? DataCancelamento { get; set; }

        public void Cancelar()
        {
            //ERRADO
            Situacao = 0;
            
            //CORRETO
            Situacao = (int)Situacoes.Cancelado;

            DataCancelamento = DateTime.Now;
        }

        public void AlterParaModulo(char modulo)
        {
            ModuloERP = modulo;
        }
    }
}