using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgendaWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public ContactosController(ApplicationDbContext context)
        {

            this.context = context;

        }
        [HttpGet]
        public ICollection<Contactos> Get()
        {
            return context.Contactos.ToList();
        }

        [HttpGet("{id}", Name = "newContact")]
        public IActionResult Get(int id)
        {
            var contact = context.Contactos.FirstOrDefault(x => x.Id == id);

            if (contact != null)
            {

                return Ok(contact);

            }

            return NotFound();

        }
        [HttpPost]
        public IActionResult Post([FromBody] Contactos contacto)
        {

            if (ModelState.IsValid)
            {

                context.Contactos.Add(contacto);
                context.SaveChanges();
                return (new CreatedAtRouteResult("newContact", new { id = contacto.Id }, contacto));

            }

            return BadRequest();

        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Contactos contacto, int id)
        {


            if (contacto.Id == id)
            {

                context.Entry(contacto).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(contacto);

            }

            return BadRequest();

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            var contact = context.Contactos.FirstOrDefault(x => x.Id == id);

            if (contact != null)
            {

                context.Contactos.Remove(contact);
                context.SaveChanges();
                return Ok("Contacto " + contact.ContactName + " " + contact.ContactLastName + " eliminado");

            }

            return NotFound();

        }

    }
}