using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActiviteitenroosterController : ControllerBase
    {
        private readonly ActiviteitenroosterContext _context;

        public ActiviteitenroosterController(ActiviteitenroosterContext context)
        {
            _context = context;
        }

        // GET: api/Activiteitenrooster
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActiviteitenroosterItem>>> GetActiviteitenrooster()
        {
            return await _context.Activiteitenrooster.ToListAsync();
        }

        // GET: api/Activiteitenrooster/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ActiviteitenroosterItem>> GetActiviteitenroosterItem(int id)
        {
            var activiteitenroosterItem = await _context.Activiteitenrooster.FindAsync(id);

            if (activiteitenroosterItem == null)
            {
                return NotFound();
            }

            return activiteitenroosterItem;
        }

        // PUT: api/Activiteitenrooster/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActiviteitenroosterItem(int id, ActiviteitenroosterItem activiteitenroosterItem)
        {
            if (id != activiteitenroosterItem.activiteitenRoosterID)
            {
                return BadRequest();
            }

            _context.Entry(activiteitenroosterItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActiviteitenroosterItemExists(id))
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

        // POST: api/Activiteitenrooster
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ActiviteitenroosterItem>> PostActiviteitenroosterItem(ActiviteitenroosterItem activiteitenroosterItem)
        {
            _context.Activiteitenrooster.Add(activiteitenroosterItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActiviteitenroosterItem", new { id = activiteitenroosterItem.activiteitenRoosterID }, activiteitenroosterItem);
        }

        // DELETE: api/Activiteitenrooster/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ActiviteitenroosterItem>> DeleteActiviteitenroosterItem(int id)
        {
            var activiteitenroosterItem = await _context.Activiteitenrooster.FindAsync(id);
            if (activiteitenroosterItem == null)
            {
                return NotFound();
            }

            _context.Activiteitenrooster.Remove(activiteitenroosterItem);
            await _context.SaveChangesAsync();

            return activiteitenroosterItem;
        }

        private bool ActiviteitenroosterItemExists(int id)
        {
            return _context.Activiteitenrooster.Any(e => e.activiteitenRoosterID == id);
        }
    }
}
