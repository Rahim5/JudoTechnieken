using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using JudoTechnieken.Model;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        public IActionResult CreateTechniek([FromBody] Technieken newTechniek)
        {
            context.Technieken.Add(newTechniek);
            context.SaveChanges();
            return Created("", newTechniek);
        }


    }
}