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
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public UsuariosController(ApplicationDbContext context)
        {

            this.context = context;

        }

        [HttpGet]
        public ICollection<Usuarios> Get()
        {

            return context.Usuarios.Include(x=> x.Contacts).ToList();

        }

        [HttpGet("{id}", Name = "newUser")]
        public IActionResult Get(int id)
        {
            var usuario = context.Usuarios.Include(x=>x.Contacts).FirstOrDefault(x => x.Id == id);

            if (usuario != null)
            {

                return Ok(usuario);

            }

            return NotFound();

        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuarios usuario)
        {
            if (ModelState.IsValid)
            {

                context.Usuarios.Add(usuario);
                context.SaveChanges();
                return (new CreatedAtRouteResult("newUser", new { id = usuario.Id }, usuario));

            }

            return BadRequest();

        }

        [HttpPut("{id}")]

        public IActionResult Put([FromBody] Usuarios usuario, int id)
        {

            
            if (usuario.Id == id)
            {

                context.Entry(usuario).State = EntityState.Modified;
                context.SaveChanges();
                return Ok(usuario);

            }

            return BadRequest();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            var usuario = context.Usuarios.FirstOrDefault(x => x.Id == id);

            if (usuario != null)
            {

                context.Usuarios.Remove(usuario);
                context.SaveChanges();
                return Ok("Usuario " + usuario.Name + " " + usuario.LastName + "Eliminado");

            }

            return NotFound();

        }
    }
}