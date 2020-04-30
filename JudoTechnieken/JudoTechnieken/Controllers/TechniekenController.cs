using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JudoTechnieken.Controllers
{   
    [Route("api/v1/technieken")]
    public class TechniekenController : Controller
    {   
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}