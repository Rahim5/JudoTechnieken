using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JudoTechnieken.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JudoTechnieken.Controllers
{
    [Route("api/v1/people")]
    public class PeopleController : Controller
    {
        private readonly JudoContext context;

        public PeopleController(JudoContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public List<People> GetAllPeople()
        {
            return context.People.ToList();
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetPeople(int id)
        {
            var people = context.People.Find(id);
            if (people == null)
            {
                return NotFound();
            }
            return Ok(people);
        }

        [HttpPost]
        public IActionResult CreatePeople([FromBody] People newPeople)
        {
            context.People.Add(newPeople);
            context.SaveChanges();
            return Created("", newPeople);
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult DeletePeople(int id)
        {
            var people = context.People.Find(id);
            if (people == null)
            {
                return NotFound();
            }
            context.People.Remove(people);
            context.SaveChanges();
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdatePeople([FromBody] People updatePeople)
        {
            var orgPeople = context.People.Find(updatePeople.Id);
            if (orgPeople == null)
            {
                return NotFound();
            }
            orgPeople.Name = updatePeople.Name;
            orgPeople.FirstName = updatePeople.FirstName;
            orgPeople.Height= updatePeople.Height;
            orgPeople.Weight = updatePeople.Weight;

            context.SaveChanges();
            return Ok(orgPeople);


        }


    }
}