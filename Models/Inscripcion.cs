using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoFinal.Models
{
    public class Inscripcion
    {
        //CAMPOS
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int inscripcion_id { get; set; }
        [Required]
        [ForeignKey("Usuario")]
        public string usuario_id { get; set; }
        [Required]
        [ForeignKey("Evento")]
        public string evento_id { get; set; }

        public int valoracion { get; set; }

        //PROPIEDADES DE NAVEGACIÓN
        [System.Text.Json.Serialization.JsonIgnore]
        public Usuario usuario { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public Evento evento { get; set; }
    }
}

//modeBuilder.Entity<ENTITYCLASS>().HasIndex(x => new {x.PROPERTY1, x.PROPERTY2, ...})
