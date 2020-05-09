using JudoTechnieken.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JudoTechniek.Model
{

    public class Techniek
    {
       
        public int TechniekId { get; set; }
        [Required(ErrorMessage ="Naam is noodzakelijk")]
        [StringLength(200,ErrorMessage ="Naam is te lang, mag maximaal 200 karakters bevattten")]
        public string Naam { get; set; }
        [Required(ErrorMessage ="Techniek type is noodzakelijk")]
        public string Type { get; set; }
        [Required(ErrorMessage ="Moeilijkheidsgraad is noodzakelijk")]
        public string Moeilijkheidsgraad{ get; set; }
        [Url]
        public string URL { get; set; }
        public Gordel Gordel { get; set; }
        public IList<TechniekPersoon> TechniekPersonen { get; set; }

    }
}
