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
            int count = 0;
            for (int x = 0; x < 50; x++)
            {
                var p = new Techniek()
                {
                    Naam = "techniek" + count,
                    Type = "beenworp",
                    Moeilijkheidsgraad = "makkelijk",
                };
                var q = new Techniek()
                {
                    Naam = "banana" + count,
                    Type = "grond",
                    Moeilijkheidsgraad = "hard",
                };
                count++;

                context.Technieken.Add(p);
                context.Technieken.Add(q);
            }
           
            context.SaveChanges();



        }       
    }
}
