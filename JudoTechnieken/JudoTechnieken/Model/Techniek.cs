using JudoTechnieken.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JudoTechniek.Model
{
    public class Techniek
    {
       
        public int TechniekId { get; set; }
        public string Naam { get; set; }
        public string Type { get; set; }
        public string Moeilijkheidsgraad{ get; set; }
        public string URL { get; set; }
        public Gordel Gordel { get; set; }
        public IList<TechniekPersoon> TechniekPersonen { get; set; }

    }
}
