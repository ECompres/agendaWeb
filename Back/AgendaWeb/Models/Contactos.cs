using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaWeb.Models
{
    public class Contactos
    {
        [Key]
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string ContactLastName { get; set; }
        public string TelephoneNumber { get; set; }
        [ForeignKey("usuario")]
        public int UsuarioId { get; set; }
        public Usuarios Usuario { get; set; }

    }
}
