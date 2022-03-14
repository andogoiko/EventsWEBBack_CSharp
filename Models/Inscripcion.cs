using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.Models
{
    public class Inscripcion
    {
        //CAMPOS
        [Key]
        public int InscripcionId { get; set; }
        [Required]
        [ForeignKey("Usuario")]
        public string usuarioId { get; set; }
        [Required]
        [ForeignKey("Evento")]
        public string eventoId { get; set; }

        public int valoracion { get; set; }

        //PROPIEDADES DE NAVEGACIÓN
        [System.Text.Json.Serialization.JsonIgnore]
        public Usuario Usuario { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public Evento Evento { get; set; }
    }
}

//modeBuilder.Entity<ENTITYCLASS>().HasIndex(x => new {x.PROPERTY1, x.PROPERTY2, ...})
