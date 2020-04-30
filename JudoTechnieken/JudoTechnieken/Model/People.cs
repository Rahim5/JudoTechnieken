using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JudoTechnieken.Model
{
    public class People
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public Gordel Gordel { get; set; }
        //[JsonIgnore]
        ////public ICollection<Technieken> Technieken { get; set; }

    }
}
