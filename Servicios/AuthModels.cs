﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoFinal.Servicios
{
    public class AuthRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }

    public class AuthResponse
    {
        public int usuarioId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
         public string about_me { get; set; }
        public bool admin { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string imagen { get; set; }
        public string Token { get; set; }
        public System.DateTime ValidTo { get; set; }

    }
}