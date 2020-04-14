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
    public class ModuleController : ControllerBase
    {
        private readonly ModuleContext _context;

        public ModuleController(ModuleContext context)
        {
            _context = context;
        }

        // GET: api/Module
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModuleItem>>> GetModule()
        {
            return await _context.Module.ToListAsync();
        }

        // GET: api/Module/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ModuleItem>> GetModuleItem(int id)
        {
            var moduleItem = await _context.Module.FindAsync(id);

            if (moduleItem == null)
            {
                return NotFound();
            }

            return moduleItem;
        }

        // PUT: api/Module/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModuleItem(int id, ModuleItem moduleItem)
        {
            if (id != moduleItem.moduleID)
            {
                return BadRequest();
            }

            _context.Entry(moduleItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModuleItemExists(id))
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

        // POST: api/Module
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ModuleItem>> PostModuleItem(ModuleItem moduleItem)
        {
            _context.Module.Add(moduleItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetModuleItem", new { id = moduleItem.moduleID }, moduleItem);
        }

        // DELETE: api/Module/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ModuleItem>> DeleteModuleItem(int id)
        {
            var moduleItem = await _context.Module.FindAsync(id);
            if (moduleItem == null)
            {
                return NotFound();
            }

            _context.Module.Remove(moduleItem);
            await _context.SaveChangesAsync();

            return moduleItem;
        }

        private bool ModuleItemExists(int id)
        {
            return _context.Module.Any(e => e.moduleID == id);
        }
    }
}
