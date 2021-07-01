using Microsoft.EntityFrameworkCore;
using SistemaOS.Data.Map;
using SistemaOS.Models;


namespace SistemaOS.Data
{
    public class SistemaOsContext : DbContext
    {
        public DbSet<OrdemServico> OrdemServico { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SVR-BI01;Initial Catalog=SistemaOs;Integrated Security=False;User ID=sa;Password=123456;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new OrdemServicoMap());

        }
    }
}
