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
    [Route("api/Campeonato")]
    [ApiController]
    public class CampeonatosSydyController : ControllerBase
    {

        private readonly IServiceCampeonatoSydy _serviceCampeonatoSydy;

        public CampeonatosSydyController(IServiceCampeonatoSydy serviceCampeonatoSydy)
        {
            _serviceCampeonatoSydy = serviceCampeonatoSydy;
        }

        // GET: api/CampeonatoSydyEntities
        [HttpGet]
        public IActionResult GetCampeonatoSydy()
        {

            var campeonato = _serviceCampeonatoSydy.RecoverAll();

            return Ok(campeonato);
        }

        //// GET: api/CampeonatoSydyEntities/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<CampeonatoSydyEntity>> GetCampeonatoSydyEntity(int id)
        //{
        //    var campeonatoSydyEntity = await _context.CampeonatoSydy.FindAsync(id);

        //    if (campeonatoSydyEntity == null)
        //    {
        //        return NotFound();
        //    }

        //    return campeonatoSydyEntity;
        //}

        //// PUT: api/CampeonatoSydyEntities/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCampeonatoSydyEntity(int id, CampeonatoSydyEntity campeonatoSydyEntity)
        //{
        //    if (id != campeonatoSydyEntity.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(campeonatoSydyEntity).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CampeonatoSydyEntityExists(id))
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

        //// POST: api/CampeonatoSydyEntities
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<CampeonatoSydyEntity>> PostCampeonatoSydyEntity(CampeonatoSydyEntity campeonatoSydyEntity)
        //{
        //    _context.CampeonatoSydy.Add(campeonatoSydyEntity);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCampeonatoSydyEntity", new { id = campeonatoSydyEntity.Id }, campeonatoSydyEntity);
        //}

        //// DELETE: api/CampeonatoSydyEntities/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<CampeonatoSydyEntity>> DeleteCampeonatoSydyEntity(int id)
        //{
        //    var campeonatoSydyEntity = await _context.CampeonatoSydy.FindAsync(id);
        //    if (campeonatoSydyEntity == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.CampeonatoSydy.Remove(campeonatoSydyEntity);
        //    await _context.SaveChangesAsync();

        //    return campeonatoSydyEntity;
        //}

        //private bool CampeonatoSydyEntityExists(int id)
        //{
        //    return _context.CampeonatoSydy.Any(e => e.Id == id);
        //}
    }
}
