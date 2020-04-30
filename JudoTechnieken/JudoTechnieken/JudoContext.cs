using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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


    }
}
