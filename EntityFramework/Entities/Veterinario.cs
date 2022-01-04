using System;

namespace Domain.Entities
{
    public class Veterinario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Especialidade { get; set; }
        public decimal Salario { get; set; }
    }
}
