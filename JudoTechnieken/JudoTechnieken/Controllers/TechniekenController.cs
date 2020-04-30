using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using JudoTechnieken.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JudoTechnieken.Controllers
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
        public List<Technieken> GetAllTechnieken()
        {
            return context.Technieken.ToList();
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetTechniek(int id)
        {
            var techniek = context.Technieken.Find(id);
            if (techniek==null)
            {
                return NotFound();
            }
            return Ok(techniek);
        }

        [HttpPost]
        public IActionResult CreateTechniek([FromBody] Technieken newTechniek)
        {
            context.Technieken.Add(newTechniek);
            context.SaveChanges();
            return Created("", newTechniek);
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult DeleteTechniek(int id)
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
        public IActionResult UpdateTechniek([FromBody] Technieken updateTechniek)
        {
            var orgTechniek = context.Technieken.Find(updateTechniek.Id);
            if (orgTechniek==null)
            {
                return NotFound();
            }
            orgTechniek.Name = updateTechniek.Name;
            orgTechniek.Type = updateTechniek.Type;
            orgTechniek.Difficulty = updateTechniek.Difficulty;
            orgTechniek.URL = updateTechniek.URL;

            context.SaveChanges();
            return Ok(orgTechniek);


        }


    }
}