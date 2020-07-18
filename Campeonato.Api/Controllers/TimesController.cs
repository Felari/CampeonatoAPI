using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Campeonato.Domain.Entidade;
using Campeonato.Infra.Data.Context;
using Campeonato.Domain.Interfaces;

namespace Campeonato.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesController : Controller
    {
        private readonly IServiceTime _serviceTime;


        public TimesController(IServiceTime serviceTime)
        {
            _serviceTime = serviceTime;
        }

        // GET: api/Times
        [HttpGet]
        public IActionResult GetTime()
        {
            var time = _serviceTime.RecoverAll();

            return Ok(time);
        }

        // GET: api/Times/5
        [HttpGet("{id}")]
        public IActionResult GetTime(int id)
        {
            var time = _serviceTime.RecoverById(id);

            if (time == null)
            {
                return NotFound();
            }

            return Ok(time);
        }

        //// PUT: api/Times/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTime(int id, Time time)
        //{
        //    if (id != time.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(time).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TimeExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Times
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<Time>> PostTime(Time time)
        //{
        //    _context.Time.Add(time);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetTime", new { id = time.Id }, time);
        //}

        //// DELETE: api/Times/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Time>> DeleteTime(int id)
        //{
        //    var time = await _context.Time.FindAsync(id);
        //    if (time == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Time.Remove(time);
        //    await _context.SaveChangesAsync();

        //    return time;
        //}

        //private bool TimeExists(int id)
        //{
        //    return _context.Time.Any(e => e.Id == id);
        //}
    }
}
