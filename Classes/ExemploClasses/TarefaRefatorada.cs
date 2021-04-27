using System;

namespace ExemploClasses
{
    public class TarefaRefatorada
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataAgendamento { get; private set; }
        public Situacao Situacao { get; private set; }
        public DateTime? DataConclusao { get; private set; }

        public TarefaRefatorada()
        {
            DataAgendamento = DateTime.Now;
            Situacao = Situacao.NaoIniciado;
        }
        
        public TarefaRefatorada(int id, string nome) : this()
        {
            Id = id;
            Nome = nome;
        }

        public void AlterarDataAgendamento(DateTime data)
        {
            if (Situacao == Situacao.NaoIniciado)
                DataAgendamento = data;
            else
            {
                //Implementação de retorno de erro, exception, etc
            }

        }

        public void Processar()
        {
            if (Situacao == Situacao.NaoIniciado)
                Situacao = Situacao.EmProcessamento;
            else
            {
                //Implementação de retorno de erro, exception, etc
            }
        }

        public void Concluir()
        {
            if (Situacao != Situacao.Concluido)
            {
                Situacao = Situacao.Concluido;
                DataConclusao = DateTime.Now;
            }
            else
            {
                //Implementação de retorno de erro, exception, etc
            }
        }
    }
}
