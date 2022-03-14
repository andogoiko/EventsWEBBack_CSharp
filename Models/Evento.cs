using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.Models
{
    public class Evento
    {
        //CAMPOS

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string eventoId { get; set; }

        [Required]
        public string fechaInic { get; set; }

        [Required]
        public string fechaFin { get; set; }

        [Required]
        public string horaInic { get; set; }

        [Required]
        public string horaFin { get; set; }

        [Required]
        [ForeignKey("Localizacion")]
        public string localizacion { get; set; }

        public string descripcion { get; set; }

        [Required]
        public string precio { get; set; }

        [Required]
        [ForeignKey("Categoria")]
        public string categoriaId { get; set; }

        //PROPIEDADES DE NAVEGACION
        [System.Text.Json.Serialization.JsonIgnore]
        public Categoria Categoria { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public Localizacion Localizacion { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public List<Comentario> Comentarios { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public List<Inscripcion> Inscripciones { get; set; }



    }
}
