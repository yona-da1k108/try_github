using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThanksCardServer2.Models;

namespace ThanksCardServer2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BelongsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public BelongsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Belongs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Belongs>>> Getbelongs()
        {
          if (_context.belongs == null)
          {
              return NotFound();
          }
            return await _context.belongs.ToListAsync();
        }

        // GET: api/Belongs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Belongs>> GetBelongs(long id)
        {
          if (_context.belongs == null)
          {
              return NotFound();
          }
            var belongs = await _context.belongs.FindAsync(id);

            if (belongs == null)
            {
                return NotFound();
            }

            return belongs;
        }

        // PUT: api/Belongs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBelongs(long id, Belongs belongs)
        {
            if (id != belongs.Belongs_Id)
            {
                return BadRequest();
            }

            _context.Entry(belongs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BelongsExists(id))
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

        // POST: api/Belongs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Belongs>> PostBelongs(Belongs belongs)
        {
          if (_context.belongs == null)
          {
              return Problem("Entity set 'ApplicationContext.belongs'  is null.");
          }
            _context.belongs.Add(belongs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBelongs", new { id = belongs.Belongs_Id }, belongs);
        }

        // DELETE: api/Belongs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBelongs(long id)
        {
            if (_context.belongs == null)
            {
                return NotFound();
            }
            var belongs = await _context.belongs.FindAsync(id);
            if (belongs == null)
            {
                return NotFound();
            }

            _context.belongs.Remove(belongs);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BelongsExists(long id)
        {
            return (_context.belongs?.Any(e => e.Belongs_Id == id)).GetValueOrDefault();
        }
    }
}
