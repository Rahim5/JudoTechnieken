using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JudoTechnieken.Model
{
    public class JudoContext: DbContext
    {
        public JudoContext (DbContextOptions<JudoContext> options): base(options)
        {

        }
        public DbSet<Gordel> Gordels { get; set; }
        public DbSet<People> People  { get; set; }
        public DbSet<Technieken> Technieken { get; set; }


    }
}
