using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.Models
{
    public class Comentario
    {
        //CAMPOS
        [Key]
        public int comentarioId { get; set; }
        [Required]
        public string comentario { get; set; }
        [Required]
        [ForeignKey("Evento")]
        public string eventoId { get; set; }
        [Required]
        [ForeignKey("Categoria")]
        public string categoriaId { get; set; }
        [Required]
        [ForeignKey("Usuario")]
        public string usuarioId { get; set; }
        [Required]
        public string fechaComentario { get; set; }

        //PROPIEDADES DE NAVEGACION

        [System.Text.Json.Serialization.JsonIgnore]
        public Usuario Usuario { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public Evento Evento { get; set; }
    }
}
