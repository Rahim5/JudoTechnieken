using JudoTechniek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JudoTechnieken.Model
{
    public class TechniekPersoon
    {
        public int TechniekId { get; set; }
        public Techniek Techniek{ get; set; }

        public int PersoonId { get; set; }
        public Persoon Persoon { get; set; }
    }
}
