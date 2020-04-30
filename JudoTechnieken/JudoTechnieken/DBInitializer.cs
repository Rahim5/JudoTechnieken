using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JudoTechnieken.Model
{
    public class DBInitializer
    {
        public static void Initialize(JudoContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Technieken.Any())
            {
                var t1 = new Technieken()
                {
                    Name= "o-soto-gari",
                    Type="beenworp",
                    Difficulty="easy"
                };
                context.Technieken.Add(t1);
                context.SaveChanges();
            }
        }
    }
}
