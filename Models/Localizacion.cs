using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.Models
{
    public class Localizacion
    {
        //CAMPOS

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string localizacionId { get; set; }

        [Required]
        public double latitud { get; set; }

        [Required]
        public double longitud { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public List<Evento> Eventos { get; set; }


    }
}
