using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JudoTechnieken.Model
{
    public class Gordel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
        public int Age { get; set; }
        //[JsonIgnore]
        //public ICollection<Technieken> Technieken { get; set; }
        //[JsonIgnore]
        //public ICollection<People> People { get; set; }
    }
}
