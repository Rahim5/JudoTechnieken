using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using JudoTechniek.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JudoTechniek.Controllers
{   
    [Route("api/v1/technieken")]
    public class TechniekenController : Controller
    {
        private readonly JudoContext context;
        
        public TechniekenController(JudoContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public List<Techniek> KrijgAlleTechnieken()
        {
            return context.Technieken.ToList();
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult KrijgTechniek(int id)
        {
            var techniek = context.Technieken.Find(id);
            if (techniek==null)
            {
                return NotFound();
            }
            return Ok(techniek);
        }

        [HttpPost]
        public IActionResult TechniekAanmaken([FromBody] Techniek nieuwTechniek)
        {
            context.Technieken.Add(nieuwTechniek);
            context.SaveChanges();
            return Created("", nieuwTechniek);
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult VerwijderTechniek(int id)
        {
            var techniek = context.Technieken.Find(id);
            if (techniek==null)
            {
                return NotFound();
            }
            context.Technieken.Remove(techniek);
            context.SaveChanges();
            return NoContent();
        }

        [HttpPut]
        public IActionResult TechniekBijwerken([FromBody] Techniek bijgewerkteTechniek)
        {
            var orgTechniek = context.Technieken.Find(bijgewerkteTechniek.Id);
            if (orgTechniek==null)
            {
                return NotFound();
            }
            
            orgTechniek.Naam = bijgewerkteTechniek.Naam;
            orgTechniek.Type = bijgewerkteTechniek.Type;
            orgTechniek.Moeilijkheidsgraad = bijgewerkteTechniek.Moeilijkheidsgraad;
            orgTechniek.URL = bijgewerkteTechniek.URL;

            context.SaveChanges();
            return Ok(orgTechniek);


        }


    }
}