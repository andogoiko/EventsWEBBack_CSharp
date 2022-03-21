using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoFinal.Models
{
    public class Evento
    {
        //CAMPOS
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string evento_id { get; set; }

        public string evento { get; set; }

        [Required]
        public string fecha_inic { get; set; }

        [Required]
        public string fecha_fin { get; set; }

        [Required]
        public string hora_inic { get; set; }

        [Required]
        public string hora_fin { get; set; }

        [Required]
        [ForeignKey("Localizacion")]
        public string localizacion_id { get; set; }

        public string descripcion { get; set; }

        [Required]
        public string precio { get; set; }

        [Required]
        [ForeignKey("Categoria")]
        public string categoria_id { get; set; }

        //PROPIEDADES DE NAVEGACION
        [System.Text.Json.Serialization.JsonIgnore]
        public Categoria categoria { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public Localizacion localizacion { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public List<Comentario> comentarios { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public List<Inscripcion> inscripciones { get; set; }



    }
}
