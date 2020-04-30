using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JudoTechnieken.Model
{
    public class Technieken
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Difficulty { get; set; }
        public string URL { get; set; }
        public Gordel Gordel { get; set; }
        //[JsonIgnore]
        //public ICollection<People> People { get; set; }

    }
}
