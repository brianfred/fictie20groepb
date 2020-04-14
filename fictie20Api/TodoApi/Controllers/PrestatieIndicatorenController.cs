using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrestatieIndicatoren.Models;

namespace TodoApi.Controllers
{
    [Route("api/PrestatieIndicatoren")]
    [ApiController]
    public class PrestatieIndicatorenController : ControllerBase
    {
        private readonly PrestatieIndicatorenContext _context;

        public PrestatieIndicatorenController(PrestatieIndicatorenContext context)
        {
            _context = context;
        }

        // GET: api/PrestatieIndicatoren
        [DisableCors]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PrestatieIndicatorenItem>>> GetPrestatieIndicatoren()
        {
            return await _context.PrestatieIndicatoren.ToListAsync();
        }

        // GET: api/PrestatieIndicatoren/5
        [DisableCors]
        [HttpGet("{id}")]
        public async Task<ActionResult<PrestatieIndicatorenItem>> GetPrestatieIndicatorenItem(int id)
        {
            var prestatieIndicatorenItem = await _context.PrestatieIndicatoren.FindAsync(id);

            if (prestatieIndicatorenItem == null)
            {
                return NotFound();
            }

            return prestatieIndicatorenItem;
        }

        // PUT: api/PrestatieIndicatoren/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [DisableCors]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrestatieIndicatorenItem(int id, PrestatieIndicatorenItem prestatieIndicatorenItem)
        {
            if (id != prestatieIndicatorenItem.prestatieindicatorID)
            {
                return BadRequest();
            }

            _context.Entry(prestatieIndicatorenItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrestatieIndicatorenItemExists(id))
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

        // POST: api/PrestatieIndicatoren
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [DisableCors]
        [HttpPost]
        public async Task<ActionResult<PrestatieIndicatorenItem>> PostPrestatieIndicatorenItem(PrestatieIndicatorenItem prestatieIndicatorenItem)
        {
            _context.PrestatieIndicatoren.Add(prestatieIndicatorenItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrestatieIndicatorenItem", new { id = prestatieIndicatorenItem.prestatieindicatorID }, prestatieIndicatorenItem);
        }

        // DELETE: api/PrestatieIndicatoren/5
        [DisableCors]
        [HttpDelete("{id}")]
        public async Task<ActionResult<PrestatieIndicatorenItem>> DeletePrestatieIndicatorenItem(int id)
        {
            var prestatieIndicatorenItem = await _context.PrestatieIndicatoren.FindAsync(id);
            if (prestatieIndicatorenItem == null)
            {
                return NotFound();
            }

            _context.PrestatieIndicatoren.Remove(prestatieIndicatorenItem);
            await _context.SaveChangesAsync();

            return prestatieIndicatorenItem;
        }

        private bool PrestatieIndicatorenItemExists(int id)
        {
            return _context.PrestatieIndicatoren.Any(e => e.prestatieindicatorID == id);
        }
    }
}
