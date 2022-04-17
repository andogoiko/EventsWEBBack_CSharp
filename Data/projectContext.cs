using proyectoFinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using proyectoFinal.Settings;
using proyectoFinal.Servicios;
namespace proyectoFinal.Data
{
    public class projectContext : DbContext
    {
        public static string connString { get; private set; } = $"Server=185.60.40.210\\SQLEXPRESS,58015;Database=proyecto_eventos;User Id=sa;Password=Pa88word";
        private readonly AppSettings _appSettings;
        public projectContext(IOptions<AppSettings> appSettings,DbContextOptions<projectContext> options)
            : base(options)
        {
              _appSettings = appSettings.Value;
        }

        public AuthResponse Authenticate(AuthRequest user)
        {
            var user1 = Usuarios.SingleOrDefault(u => u.username == user.Username && u.password == user.Password);

            // 1.- control null
            if (user1 == null) return null;
            // 2.- control db

            // autenticacion válida -> generamos jwt
            var (token, validTo) = generateJwtToken(user1);

            // Devolvemos lo que nos interese
            return new AuthResponse
            {
                usuarioId = user1.usuarioId,
                nombre = user1.nombre,
                apellido = user1.apellido,
                email = user1.email,
                Token = token,
                ValidTo = validTo
            };

        }


        public Usuario GetById(int id)
        {
            return Usuarios.FirstOrDefault(x => x.usuarioId == id);
        }
        public IEnumerable<Usuario> GetAll()
        {
            return Usuarios;
        }

        // internos
        private (string token, DateTime validTo) generateJwtToken(Usuario user)
        {
            // generamos un token válido para 7 días
            var dias = 7;
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
              

                Expires = DateTime.UtcNow.AddDays(dias),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return (token: tokenHandler.WriteToken(token), validTo: token.ValidTo);
        }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>()
                .HasIndex(u => u.usuarioId)
                .IsUnique();

            builder.Entity<Usuario>()
            .Property(us => us.administrator)
            .HasDefaultValue(false);

            builder.Entity<Evento>()
            .Property(cu => cu.popularidad)
            .HasDefaultValue(0);
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
