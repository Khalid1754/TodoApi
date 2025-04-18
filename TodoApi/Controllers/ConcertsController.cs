﻿using System;
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
    public class ConcertsController : ControllerBase
    {
        private readonly TodoContext _context;

        public ConcertsController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/Concerts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Concert>>> GetConcert()
        {
            return await _context.Concert.ToListAsync();
        }

        // GET: api/Concerts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Concert>> GetConcert(int id)
        {
            var concert = await _context.Concert.FindAsync(id);

            if (concert == null)
            {
                return NotFound();
            }

            return concert;
        }

        // PUT: api/Concerts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConcert(int id, Concert concert)
        {
            if (id != concert.Id)
            {
                return BadRequest();
            }

            _context.Entry(concert).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConcertExists(id))
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

        // POST: api/Concerts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Concert>> PostConcert(Concert concert)
        {
            _context.Concert.Add(concert);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConcert", new { id = concert.Id }, concert);
        }

        // DELETE: api/Concerts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConcert(int id)
        {
            var concert = await _context.Concert.FindAsync(id);
            if (concert == null)
            {
                return NotFound();
            }

            _context.Concert.Remove(concert);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConcertExists(int id)
        {
            return _context.Concert.Any(e => e.Id == id);
        }
    }
}
