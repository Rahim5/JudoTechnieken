using JudoTechnieken.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JudoTechniek.Model
{
    public class Persoon
    {
        public int PersoonId { get; set; }
        [Required(ErrorMessage ="Een achternaam is noodzakelijk")]
        public string Achternaam { get; set; }
        [Required(ErrorMessage ="Een voornaam is noodzakelijk")]
        public string Voornaam { get; set; }
        [EmailAddress(ErrorMessage ="Email adres is ongeldig")]
        public string Email { get; set; }
        [Range(0,150, ErrorMessage ="Leeftijd is ongeldig (0-150)")]
        public int Leeftijd { get; set; }
        [Range(0,300,ErrorMessage ="Hoogte is ongeldig (0-300)")]
        public int Hoogte { get; set; }
        [Range(0, 500, ErrorMessage = "Gewicht is ongeldig (0-500)")]
        public int Gewicht { get; set; }
        public Gordel Gordel { get; set; }
        public IList<TechniekPersoon> TechniekPersonen { get; set; }

    }
}
