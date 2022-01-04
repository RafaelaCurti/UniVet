using System;

namespace Domain.Entities
{
    public class Proprietario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Paciente Paciente { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public int Celular { get; set; }
    }
}