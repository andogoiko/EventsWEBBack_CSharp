using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using proyectoFinal.Data;
using proyectoFinal.Models;
using proyectoFinal.Servicios;
using System.Reflection;

namespace proyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly projectContext _context;
        private projectContext _userService;
        
        public UsuarioController(projectContext context)
        {
            _context = context;
        }
        
        // GET: api/Usuario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        // GET: api/Usuario/username/password
        [HttpGet("{username}/{password}")]
        public  ActionResult<List<Usuario>> GetIniciarSesion(string username, string password)
        {
            var usuario =  _context.Usuarios.Where(usuario => usuario.username.Equals(username) && usuario.password.Equals(password)).ToList();

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // GET: api/Usuario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // GET: api/Comentario/Usuario/5
        [HttpGet("Usuario/{id}")]
        public async  Task<List<Comentario>> GetComentariosDeUsuario(int id)
        {
            var comentarios = await _context.Comentarios.Where(w=>w.usuarioId ==id).ToListAsync();
            return comentarios;
        } 

        // GET: api/Usuario/Eventos/5
        [HttpGet("Eventos/{id}")]
        public async Task<IEnumerable<dynamic>> GetEventosUsuario(int id)
        {

            List<dynamic> eventosUser = new List<dynamic>();
        
            var inscripciones = await _context.Inscripciones.Where(w=>w.usuarioId == id).ToListAsync();

            foreach (var inscripcion in inscripciones)
            {

                var auxList = await _context.Eventos.Where(w=>w.eventoId == inscripcion.eventoId).ToListAsync();
                eventosUser.Add(auxList[0]);
                
            }

            return eventosUser;
        }
        
        // PUT: api/Usuario/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
                Console.Write(usuario.ToString());

            if (id != usuario.usuarioId)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Usuario
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuario", new { id = usuario.usuarioId }, usuario);
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthRequest user)
        {
            Console.WriteLine(user);
            var response = _context.Authenticate(user);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

      


        // DELETE: api/Usuario/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.usuarioId == id);
        }
    }
}
