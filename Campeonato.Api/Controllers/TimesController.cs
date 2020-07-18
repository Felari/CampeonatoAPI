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
using Campeonato.Domain.Models;
using AutoMapper;

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

        // PUT: api/Times/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTime(AtualizaTimeViewModel time)
        {
            var timeAtualiza = Mapper.Map<VisualizaTimeViewModel, AtualizaTimeViewModel>(_serviceTime.RecoverById(time.Id));

            if (timeAtualiza == null)
            {
                return BadRequest();
            }

            var Time = _serviceTime.Update(timeAtualiza);


            return Ok(Time);
        }

        // POST: api/Times
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public IActionResult PostTime(AdicionaTimeViewModel time)
        {
           var TimeAdd = _serviceTime.Insert(time);            

            return Ok(TimeAdd);
        }

        // DELETE: api/Times/5
        [HttpDelete("{id}")]
        public IActionResult DeleteTime(int id)
        {
            var time = _serviceTime.RecoverById(id);
            if (time == null)
            {
                return NotFound();
            }

            _serviceTime.Delete(id);

            return Ok("Okay");
        }

    }
}
