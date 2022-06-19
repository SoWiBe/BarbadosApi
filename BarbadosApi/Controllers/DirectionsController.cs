using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BarbadosApi.Models;

namespace BarbadosApi.Controllers
{
    [Produces("application/json")]
    [Route("api/directions")]
    [ApiController]
    public class DirectionsController : ControllerBase
    {
        private readonly MainContext _context;

        public DirectionsController(MainContext context)
        {
            _context = context;
        }

        // GET: api/Directions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Direction>>> GetDirections()
        {
            return await _context.Directions.ToListAsync();
        }

        // GET: api/Directions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Direction>> GetDirection(int id)
        {
            var direction = await _context.Directions.FindAsync(id);

            if (direction == null)
            {
                return NotFound();
            }

            return direction;
        }

        // PUT: api/Directions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDirection(int id, Direction direction)
        {
            if (id != direction.Id)
            {
                return BadRequest();
            }

            _context.Entry(direction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DirectionExists(id))
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

        // POST: api/Directions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Direction>> PostDirection([FromBody] Direction direction)
        {
            _context.Directions.Add(direction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDirection", new { id = direction.Id }, direction);
        }

        // DELETE: api/Directions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Direction>> DeleteDirection(int id)
        {
            var direction = await _context.Directions.FindAsync(id);
            if (direction == null)
            {
                return NotFound();
            }

            _context.Directions.Remove(direction);
            await _context.SaveChangesAsync();

            return direction;
        }

        private bool DirectionExists(int id)
        {
            return _context.Directions.Any(e => e.Id == id);
        }
    }
}
