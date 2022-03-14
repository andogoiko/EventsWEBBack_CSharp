using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.Models
{
    public class Categoria
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string categoriaId {get;set;}
        [Required]
        public string descripcionCategoria { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public List<Evento> Eventos { get; set; }
    }
}
