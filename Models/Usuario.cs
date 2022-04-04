using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoFinal.Models
{
    public class Usuario
    {
        //CAMPOS

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int usuarioId { get; set; }

        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string email { get; set; }

        public bool administrator { get; set; }

        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string imagen { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public List<Comentario> comentarios { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public List<Inscripcion> inscripciones { get; set; }

    }
}
