using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoFinal.Models
{
    public class Conversacion
    {
        //CAMPOS
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int conversacionId { get; set; }

        public string nombreConversacion { get; set; }

    }
}
