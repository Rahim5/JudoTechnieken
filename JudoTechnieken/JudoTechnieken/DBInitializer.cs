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
            

        }       
    }
}
