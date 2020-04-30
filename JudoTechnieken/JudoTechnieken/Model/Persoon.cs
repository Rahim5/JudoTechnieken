using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JudoTechniek.Model
{
    public class Persoon
    {
        
        public int Id { get; set; }
        public string Achternaam { get; set; }
        public string Voornaam { get; set; }
        public int Leeftijd { get; set; }
        public int Hoogte { get; set; }
        public int Gewicht { get; set; }
        public Gordel Gordel { get; set; }
        //[JsonIgnore]
        ////public ICollection<Techniek> Technieken { get; set; }

    }
}
