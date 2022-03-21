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
    public class LocalizacionController : ControllerBase
    {
        private readonly projectContext _context;

        public LocalizacionController(projectContext context)
        {
            _context = context;
        }

        // GET: api/Localizacion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Localizacion>>> GetLocalizaciones()
        {
            return await _context.Localizaciones.ToListAsync();
        }

        // GET: api/Localizacion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Localizacion>> GetLocalizacion(int id)
        {
            var localizacion = await _context.Localizaciones.FindAsync(id);

            if (localizacion == null)
            {
                return NotFound();
            }

            return localizacion;
        }

        // PUT: api/Localizacion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocalizacion(int id, Localizacion localizacion)
        {
            if (id != localizacion.localizacionId)
            {
                return BadRequest();
            }

            _context.Entry(localizacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocalizacionExists(id))
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

        // POST: api/Localizacion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Localizacion>> PostLocalizacion(Localizacion localizacion)
        {
            _context.Localizaciones.Add(localizacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocalizacion", new { id = localizacion.localizacionId }, localizacion);
        }

        // DELETE: api/Localizacion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocalizacion(int id)
        {
            var localizacion = await _context.Localizaciones.FindAsync(id);
            if (localizacion == null)
            {
                return NotFound();
            }

            _context.Localizaciones.Remove(localizacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LocalizacionExists(int id)
        {
            return _context.Localizaciones.Any(e => e.localizacionId == id);
        }
    }
}
