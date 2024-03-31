using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwis_pogodowy_GUI
{
    internal class BazaPogoda : DbContext
    {
        public DbSet <Pogoda_inicjalizuj> PogodaInicjalizuj { get; set; }
        public BazaPogoda()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@" Data source = Pogoda.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pogoda_inicjalizuj>().HasData(
                new Pogoda_inicjalizuj { Id = 1, miasto = "Warszawa", temperatura = 20, cisnienie = 959 },
                new Pogoda_inicjalizuj { Id = 2, miasto = "Gdańsk", temperatura = 18, cisnienie = 965 });
        }
    }
}
