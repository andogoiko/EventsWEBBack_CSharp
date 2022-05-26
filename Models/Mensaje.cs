using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoFinal.Models
{
    public class Mensaje
    {
        //CAMPOS
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int mensajeId { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        public int usuarioId { get; set; }

        [Required]
        [ForeignKey("Conversacion")]
        public int conversacionId { get; set; }

        public string mensajeTexto { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime fechaEnviado { set; get; }

        //PROPIEDADES DE NAVEGACION

        [System.Text.Json.Serialization.JsonIgnore]
        public Usuario usuario { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public Conversacion conversacion { get; set; }

    }
}
