using System;

namespace ExemploClasses
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataAgendamento { get; set; }
        public int Situacao { get; set; }
        public DateTime? DataConclusao { get; set; }
    }
}
