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
        public List<Technieken> Technieken{ get; set; }
        public List<People> People { get; set; }
    }
}
