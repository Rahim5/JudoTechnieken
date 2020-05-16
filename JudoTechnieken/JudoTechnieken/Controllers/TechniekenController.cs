using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using JudoTechniek.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JudoTechniek.Controllers
{   
    [Route("api/v1/technieken")]
    [ApiController]
    public class TechniekenController : ControllerBase
    {
        private readonly JudoContext context;
        
        public TechniekenController(JudoContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public List<Techniek> KrijgAlleTechnieken(string naam, string type, string moeilijkheidsgraad, int? pagina, int lengte=50, string sorteer="", string richting="asc" )
        {
            IQueryable<Techniek> query = context.Technieken;

            if (!string.IsNullOrWhiteSpace(naam))
                query = query.Where(d => d.Naam == naam);
            if (!string.IsNullOrWhiteSpace(type))
                query = query.Where(d => d.Type == type);
            if (!string.IsNullOrWhiteSpace(moeilijkheidsgraad))
                query = query.Where(d => d.Moeilijkheidsgraad == moeilijkheidsgraad);


            if (!string.IsNullOrWhiteSpace(sorteer))
            {
                switch (sorteer)
                {
                    case "naam":
                        if (richting == "asc")
                            query = query.OrderBy(d => d.Naam);
                        else if (richting == "desc")
                            query.OrderByDescending(d => d.Naam);
                        break;
                    case "type":
                        if (richting == "asc")
                            query = query.OrderBy(d => d.Type);
                        else if (richting == "desc")
                            query.OrderByDescending(d => d.Type);
                        break;
                    case "moeilijkheidsgraad":
                        if (richting == "asc")
                            query = query.OrderBy(d => d.Moeilijkheidsgraad);
                        else if (richting == "desc")
                            query.OrderByDescending(d => d.Moeilijkheidsgraad);
                        break;

                }
            }


            if (pagina.HasValue)
                query = query.Skip(pagina.Value * lengte);
            query = query.Take(lengte);
            
            return query.ToList();
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
            var orgTechniek = context.Technieken.Find(bijgewerkteTechniek.TechniekId);
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