using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Paciente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Familia { get; set; }
        public string Raca { get; set; }
        public string Porte { get; set; }
        public decimal Peso { get; set; }
        public string Observacoes { get; set; }
    }
}
