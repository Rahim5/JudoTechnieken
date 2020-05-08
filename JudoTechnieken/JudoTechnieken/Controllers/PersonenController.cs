using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JudoTechniek.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JudoTechniek.Controllers
{
    [Route("api/v1/personen")]
    public class PersonenController : Controller
    {
        private readonly JudoContext context;
        public PersonenController(JudoContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public List<Persoon> KrijgAllePersonen()
        {
            return context.Personen.ToList();
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult KrijgPersoon(int id)
        {
            var persoon = context.Personen
                    .Include(d => d.Gordel)
                    .SingleOrDefault(d => d.PersoonId == id);
            if (persoon == null)
            {
                return NotFound();
            }
            return Ok(persoon);
        }

        [HttpPost]
        public IActionResult PersoonAanmaken([FromBody] Persoon nieuwPersoon)
        {
            context.Personen.Add(nieuwPersoon);
            context.SaveChanges();
            return Created("", nieuwPersoon);
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult VerwijderPersoon(int id)
        {
            var persoon = context.Personen.Find(id);
            if (persoon == null)
            {
                return NotFound();
            }
            context.Personen.Remove(persoon);
            context.SaveChanges();
            return NoContent();
        }

        [HttpPut]
        public IActionResult PersoonBijwerken([FromBody] Persoon bijgewerktePersoon)
        {
            var orgPersoon = context.Personen.Find(bijgewerktePersoon.PersoonId);
            if (orgPersoon == null)
            {
                return NotFound();
            }
            orgPersoon.Achternaam = bijgewerktePersoon.Achternaam;
            orgPersoon.Voornaam = bijgewerktePersoon.Voornaam;
            orgPersoon.Hoogte= bijgewerktePersoon.Hoogte;
            orgPersoon.Gewicht = bijgewerktePersoon.Gewicht;

            context.SaveChanges();
            return Ok(orgPersoon);


        }


    }
}