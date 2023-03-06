using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projet_C.Data;
using Projet_C.Models;

namespace Projet_C.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopcsController : ControllerBase
    {
        private readonly Projet_CContext _context;

        public PopcsController(Projet_CContext context)
        {
            _context = context;
        }

        // GET: api/Popcs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Popcs>>> GetPopcs()
        {
            return await _context.Popcs.ToListAsync();
        }

        // GET: api/Popcs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Popcs>> GetPopcs(int id)
        {
            var popcs = await _context.Popcs.FindAsync(id);

            if (popcs == null)
            {
                return NotFound();
            }

            return popcs;
        }

        // PUT: api/Popcs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPopcs(int id, Popcs popcs)
        {
            if (id != popcs.Id)
            {
                return BadRequest();
            }

            _context.Entry(popcs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PopcsExists(id))
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

        // POST: api/Popcs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Popcs>> PostPopcs(Popcs popcs)
        {
            _context.Popcs.Add(popcs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPopcs", new { id = popcs.Id }, popcs);
        }

        // DELETE: api/Popcs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePopcs(int id)
        {
            var popcs = await _context.Popcs.FindAsync(id);
            if (popcs == null)
            {
                return NotFound();
            }

            _context.Popcs.Remove(popcs);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PopcsExists(int id)
        {
            return _context.Popcs.Any(e => e.Id == id);
        }
    }
}
