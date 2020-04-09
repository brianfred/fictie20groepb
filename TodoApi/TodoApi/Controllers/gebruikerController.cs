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
    public class gebruikerController : ControllerBase
    {
        private readonly gebruikersContext _context;

        public gebruikerController(gebruikersContext context)
        {
            _context = context;
        }

        // GET: api/gebruiker
        [HttpGet]
        public async Task<ActionResult<IEnumerable<gebruikerItem>>> GetGebruiker()
        {
            return await _context.Gebruiker.ToListAsync();
        }

        // GET: api/gebruiker/5
        [HttpGet("{id}")]
        public async Task<ActionResult<gebruikerItem>> GetgebruikerItem(int id)
        {
            var gebruikerItem = await _context.Gebruiker.FindAsync(id);

            if (gebruikerItem == null)
            {
                return NotFound();
            }

            return gebruikerItem;
        }

        // GET api/Procesverbaal/gebruikersnaam/wachtwoord
        [HttpGet("{gebruikersnaam}/{wachtwoord}")]
        public Object getUser(string gebruikersnaam, string wachtwoord)
        {
            Console.WriteLine(gebruikersnaam);
            Console.WriteLine(wachtwoord);
            return _context.Gebruiker.FromSqlRaw($"select * from gebruiker where gebruikersnaam = '{gebruikersnaam}' and wachtwoord = '{wachtwoord}'").FirstOrDefault();
            //return $"{studentID}";
        }

        // PUT: api/gebruiker/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutgebruikerItem(int id, gebruikerItem gebruikerItem)
        {
            if (id != gebruikerItem.ID)
            {
                return BadRequest();
            }

            _context.Entry(gebruikerItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!gebruikerItemExists(id))
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

        // POST: api/gebruiker
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        /*[HttpGet("{id}")]
        public async Task<ActionResult<gebruikerItem>> GetInlog(string username, string password)
        {
            await _context.Gebruiker.ToListAsync();
        }*/
        
        /*public async Task<ActionResult<gebruikerItem>> GetgebruikerItem(string username, string password)
        {
            var gebruikerItem = await _context.Gebruiker.FindAsync(id);

            if (gebruikerItem == null)
            {
                return NotFound();
            }
            else if (gebruikerItem.gebruikersnaam == username)

                Console.WriteLine("abc");
            Console.WriteLine(gebruikerItem.ID);
            return gebruikerItem;
        }*/

        // DELETE: api/gebruiker/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<gebruikerItem>> DeletegebruikerItem(int id)
        {
            var gebruikerItem = await _context.Gebruiker.FindAsync(id);
            if (gebruikerItem == null)
            {
                return NotFound();
            }

            _context.Gebruiker.Remove(gebruikerItem);
            await _context.SaveChangesAsync();

            return gebruikerItem;
        }

        private bool gebruikerItemExists(int id)
        {
            return _context.Gebruiker.Any(e => e.ID == id);
        }
    }
}
