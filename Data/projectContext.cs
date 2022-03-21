using proyectoFinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoFinal.Data
{
    public class projectContext : DbContext
    {
        public static string connString { get; private set; } = $"Server=185.60.40.210\\SQLEXPRESS,58015;Database=proyecto_eventos;User Id=sa;Password=Pa88word";

        public projectContext(DbContextOptions<projectContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(connString);
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Localizacion> Localizaciones { get; set; }


    }
}
