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
    public class ConversacionUsuarioController : ControllerBase
    {
        private readonly projectContext _context;

        public ConversacionUsuarioController(projectContext context)
        {
            _context = context;
        }

        // GET: api/ConversacionUsuario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConversacionUsuario>>> GetConversacionUsuario()
        {
            return await _context.ConversacionUsuario.ToListAsync();
        }

        // GET: api/ConversacionUsuario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConversacionUsuario>> GetConversacionUsuario(int id)
        {
            var conversacionUsuario = await _context.ConversacionUsuario.FindAsync(id);

            if (conversacionUsuario == null)
            {
                return NotFound();
            }

            return conversacionUsuario;
        }

        // PUT: api/ConversacionUsuario/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{usuarioId}/{conversacionId}")]
        public async Task<IActionResult> PutConversacionUsuario(int usuarioId, int conversacionId, ConversacionUsuario conversacionUsuario)
        {
            if (usuarioId != conversacionUsuario.usuarioId && conversacionId != conversacionUsuario.conversacionId)
            {
                return BadRequest();
            }

            _context.Entry(conversacionUsuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConversacionUsuarioExists(usuarioId, conversacionId))
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

        // POST: api/ConversacionUsuario
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ConversacionUsuario>> PostConversacionUsuario(ConversacionUsuario conversacionUsuario)
        {
            _context.ConversacionUsuario.Add(conversacionUsuario);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ConversacionUsuarioExists(conversacionUsuario.usuarioId, conversacionUsuario.conversacionId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetConversacionUsuario", new { id = conversacionUsuario.usuarioId }, conversacionUsuario);
        }

        // DELETE: api/ConversacionUsuario/5
        [HttpDelete("{usuarioId}/{conversacionId}")]
        public async Task<IActionResult> DeleteConversacionUsuario(int usuarioId, int conversacionId)
        {
            var QueryconversacionUsuario = await _context.ConversacionUsuario.Where(x => x.usuarioId == usuarioId && x.conversacionId == conversacionId).ToListAsync();
            
            if (!QueryconversacionUsuario.Any())
            {
                return NotFound();
            }

            var conversacionUsuario = QueryconversacionUsuario[0];
            

            _context.ConversacionUsuario.Remove(conversacionUsuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConversacionUsuarioExists(int usuarioId, int conversacionId)
        {
            return _context.ConversacionUsuario.Any(e => e.usuarioId == usuarioId && e.conversacionId == conversacionId);
        }
    }
}
