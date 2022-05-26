using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoFinal.Models
{
    public class ConversacionUsuario
    {
        //CAMPOS

        //es key (está en el contexto)
        [Required]
        [ForeignKey("Usuario")]
        public int usuarioId { get; set; }

        //es key (está en el contexto)
        [Required]
        [ForeignKey("Conversacion")]
        public int conversacionId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime fechaAnyadido { set; get; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime fechaAbandono { set; get; }

        //PROPIEDADES DE NAVEGACION

        [System.Text.Json.Serialization.JsonIgnore]
        public Usuario usuario { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public Conversacion conversacion { get; set; }

    }
}
