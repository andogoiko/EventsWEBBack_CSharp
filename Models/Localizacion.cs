using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoFinal.Models
{
    public class Localizacion
    {
        //CAMPOS
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int localizacionId { get; set; }

        [Required]
        public string localizacion { get; set; }

        [Required]
        public double latitud { get; set; }

        [Required]
        public double longitud { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public List<Evento> eventos { get; set; }


    }
}
