using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JudoTechniek.Model
{
    public class Gordel
    {
        public int Id { get; set; }
        public string Kleur { get; set; }
        public string Graad { get; set; }
        public int nodigeLeeftijd { get; set; }
        //[JsonIgnore]
        //public ICollection<Techniek> Technieken { get; set; }
        //[JsonIgnore]
        //public ICollection<Persoon> Personen{ get; set; }
    }
}
