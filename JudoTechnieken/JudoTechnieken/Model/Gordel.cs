using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JudoTechniek.Model
{
    public class Gordel
    {
        public int GordelId { get; set; }
        [Required(ErrorMessage ="Kleur is noodzakelijk")]
        public string Kleur { get; set; }
        [Required(ErrorMessage ="Graad is noodzakelijk")]
        public string Graad { get; set; }
        [Required]
        [Range(0,150, ErrorMessage ="Leeftijd is ongeldig")]
        public int nodigeLeeftijd { get; set; }
        [JsonIgnore]
        public ICollection<Techniek> Technieken { get; set; }
        [JsonIgnore]
        public ICollection<Persoon> Personen { get; set; }
    }
}
