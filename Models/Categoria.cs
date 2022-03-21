using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoFinal.Models
{
    public class Categoria
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int categoriaId { get; set; }
        public string categoria { get; set; }
        [Required]
        public string descripcion_categoria { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public List<Evento> eventos { get; set; }
    }
}
