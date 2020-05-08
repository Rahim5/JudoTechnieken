using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JudoTechnieken.Model;
using Microsoft.EntityFrameworkCore;

namespace JudoTechniek.Model
{
    public class JudoContext: DbContext
    {
        public JudoContext (DbContextOptions<JudoContext> options): base(options)
        {

        }
        public DbSet<Gordel> Gordels { get; set; }
        public DbSet<Persoon> Personen  { get; set; }
        public DbSet<Techniek> Technieken { get; set; }
        public DbSet<TechniekPersoon> TechniekPersonen { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TechniekPersoon>().HasKey(sc => new { sc.TechniekId, sc.PersoonId });

            modelBuilder.Entity<TechniekPersoon>()
                 .HasOne(sc => sc.Techniek)
                 .WithMany(s => s.TechniekPersonen)
                 .HasForeignKey(sc => sc.TechniekId);

            modelBuilder.Entity<TechniekPersoon>()
                 .HasOne(sc => sc.Persoon)
                 .WithMany(s => s.TechniekPersonen)
                 .HasForeignKey(sc => sc.PersoonId);

        }


    }
}
