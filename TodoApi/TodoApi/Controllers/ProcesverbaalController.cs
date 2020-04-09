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
    public class ProcesverbaalController : ControllerBase
    {
        private readonly ProcesverbaalContext _context;

        public ProcesverbaalController(ProcesverbaalContext context)
        {
            _context = context;
        }

        // GET: api/Procesverbaal
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProcesverbaalItem>>> GetProcesverbaal()
        {
            //ProcesverbaalItem a = new ProcesverbaalItem;
            return await _context.Procesverbaal.ToListAsync();
            //return a;
        }

        // GET api/Procesverbaal/studentID/moduleID
        [HttpGet("{studentID}/{moduleID}")]
        public Object GetQuery(string studentID, string moduleID)
        {
            return _context.Procesverbaal.FromSqlRaw($"select * from ProcesVerbaal where studentID = {studentID} and moduleID = {moduleID}").FirstOrDefault();
            //return $"{studentID}";
        }
        /*
        // GET: api/Procesverbaal/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProcesverbaalItem>> GetProcesverbaalItem(int id)
        {
            var procesverbaalItem = await _context.Procesverbaal.FindAsync(id);

            if (procesverbaalItem == null)
            {
                return NotFound();
            }

            return procesverbaalItem;
        }*/

        // PUT: api/Procesverbaal/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProcesverbaalItem(int id, ProcesverbaalItem procesverbaalItem)
        {
            if (id != procesverbaalItem.procesverbaalID)
            {
                return BadRequest();
            }

            _context.Entry(procesverbaalItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProcesverbaalItemExists(id))
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

        // POST: api/Procesverbaal
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ProcesverbaalItem>> PostProcesverbaalItem(ProcesverbaalItem procesverbaalItem)
        {
            _context.Procesverbaal.Add(procesverbaalItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProcesverbaalItem", new { id = procesverbaalItem.procesverbaalID }, procesverbaalItem);
        }

        // DELETE: api/Procesverbaal/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProcesverbaalItem>> DeleteProcesverbaalItem(int id)
        {
            var procesverbaalItem = await _context.Procesverbaal.FindAsync(id);
            if (procesverbaalItem == null)
            {
                return NotFound();
            }

            _context.Procesverbaal.Remove(procesverbaalItem);
            await _context.SaveChangesAsync();

            return procesverbaalItem;
        }

        private bool ProcesverbaalItemExists(int id)
        {
            return _context.Procesverbaal.Any(e => e.procesverbaalID == id);
        }
    }
}
