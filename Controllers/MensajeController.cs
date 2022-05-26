using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoFinal.Data;
using proyectoFinal.Models;

namespace proyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensajeController : ControllerBase
    {
        private readonly projectContext _context;

        public MensajeController(projectContext context)
        {
            _context = context;
        }

        // GET: api/Mensaje
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mensaje>>> GetMensaje()
        {
            return await _context.Mensaje.ToListAsync();
        }

        // GET: api/Mensaje/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mensaje>> GetMensaje(int id)
        {
            var mensaje = await _context.Mensaje.FindAsync(id);

            if (mensaje == null)
            {
                return NotFound();
            }

            return mensaje;
        }

        // PUT: api/Mensaje/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMensaje(int id, Mensaje mensaje)
        {
            if (id != mensaje.mensajeId)
            {
                return BadRequest();
            }

            _context.Entry(mensaje).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MensajeExists(id))
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

        // POST: api/Mensaje
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mensaje>> PostMensaje(Mensaje mensaje)
        {
            _context.Mensaje.Add(mensaje);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMensaje", new { id = mensaje.mensajeId }, mensaje);
        }

        // DELETE: api/Mensaje/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMensaje(int id)
        {
            var mensaje = await _context.Mensaje.FindAsync(id);
            if (mensaje == null)
            {
                return NotFound();
            }

            _context.Mensaje.Remove(mensaje);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MensajeExists(int id)
        {
            return _context.Mensaje.Any(e => e.mensajeId == id);
        }
    }
}
