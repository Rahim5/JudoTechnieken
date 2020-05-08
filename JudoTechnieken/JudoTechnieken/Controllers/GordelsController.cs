using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JudoTechniek.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JudoTechniek.Controllers
{
    [Route("api/v1/gordels")]
    public class GordelsController : Controller
    {
        private readonly JudoContext context;

        public GordelsController(JudoContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public List<Gordel> KrijgAlleGordels()
        {
            return context.Gordels.ToList();
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult KrijgGordel(int id)
        {
            var gordel = context.Gordels.Find(id);
            if (gordel == null)
            {
                return NotFound();
            }
            return Ok(gordel);
        }

        [HttpPost]
        public IActionResult MaakGordel([FromBody] Gordel nieuwGordel)
        {
            context.Gordels.Add(nieuwGordel);
            context.SaveChanges();
            return Created("", nieuwGordel);
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult VerwijderGordel(int id)
        {
            var gordel = context.Gordels.Find(id);
            if (gordel == null)
            {
                return NotFound();
            }
            context.Gordels.Remove(gordel);
            context.SaveChanges();
            return NoContent();
        }

        [HttpPut]
        public IActionResult GordelBijwerken([FromBody] Gordel bijgewerkteGordel)
        {
            var orgGordel = context.Gordels.Find(bijgewerkteGordel.GordelId);
            if (orgGordel == null)
            {
                return NotFound();
            }
            orgGordel.Kleur = bijgewerkteGordel.Kleur;
            orgGordel.Graad= bijgewerkteGordel.Graad;
            orgGordel.nodigeLeeftijd = bijgewerkteGordel.nodigeLeeftijd;
            context.SaveChanges();
            return Ok(orgGordel);


        }


    }
}