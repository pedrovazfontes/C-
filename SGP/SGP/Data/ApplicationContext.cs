using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SGP.Domain;

namespace SGP.Data
{
    public class ApplicationContext : DbContext
    {
        //private static readonly ILoggerFactory _logger = LoggerFactory.Create(p => p.AddConsole());
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<FormadePgto> FormadePgtos { get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .EnableSensitiveDataLogging()
            .UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=SGP;Integrated Security=true",
            p => p.EnableRetryOnFailure
            (maxRetryCount: 2,
            maxRetryDelay: TimeSpan.FromSeconds(5),
            errorNumbersToAdd: null).MigrationsHistoryTable("SGP"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);

        }
    }


}