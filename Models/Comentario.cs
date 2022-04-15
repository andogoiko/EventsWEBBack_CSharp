using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoFinal.Models
{
    public class Comentario
    {
        //CAMPOS
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int comentarioId { get; set; }
        [Required]
        public string comentario_text { get; set; }
        [Required]
        [ForeignKey("Evento")]
        public int eventoId { get; set; }
        [Required]
        [ForeignKey("Categoria")]
        public int categoriaId { get; set; }
        [Required]
        [ForeignKey("Usuario")]
        public int usuarioId { get; set; }
        [Required]
        public string fecha_comentario { get; set; }

        //PROPIEDADES DE NAVEGACION

        [System.Text.Json.Serialization.JsonIgnore]
        public Usuario usuario { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public Evento evento { get; set; }
    }
}
