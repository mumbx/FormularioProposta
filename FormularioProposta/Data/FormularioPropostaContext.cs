using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FormularioProposta.Models;

namespace FormularioProposta.Data
{
    public class FormularioPropostaContext : DbContext
    {
        public FormularioPropostaContext (DbContextOptions<FormularioPropostaContext> options)
            : base(options)
        {
        }

        public DbSet<FormularioProposta.Models.Proposta> Proposta { get; set; }
    }
}
