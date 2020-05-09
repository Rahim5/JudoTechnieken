using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JudoTechniek.Model
{
    public class DBInitializer
    {
        public static void Initialize(JudoContext context)
        {
            context.Database.EnsureCreated();

            for (int x = 0; x < 100; x++)
            {
                var p = new Techniek()
                {
                    Naam = "Techniek " + x,
                    Type = "beenworp",
                    Moeilijkheidsgraad = "makkelijk",
                };

                context.Technieken.Add(p);
            }
           
            context.SaveChanges();



        }       
    }
}
