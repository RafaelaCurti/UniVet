using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class UnivetDbContext : DbContext
    {
        public UnivetDbContext() : base("Name=UnivetDb")
        {
            Database.SetInitializer<UnivetDbContext>(
                new CreateDatabaseIfNotExists<UnivetDbContext>());
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }


    }
}

