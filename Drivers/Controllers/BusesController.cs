using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drivers.Models;
using Drivers.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Drivers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusesController : ControllerBase
    {
        private readonly IBusRepository _busRepository;
        private readonly IDriverRepository _driverRepository;

        public BusesController(IBusRepository busRepository, IDriverRepository driverRepository)
        {
            _busRepository = busRepository;
            _driverRepository = driverRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Bus>> GetBuses() {
            return await _busRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Bus>> GetBuses(int id) {
            return await _busRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Bus>> PostBuses( Bus bus)
        {

            var newBus = await _busRepository.Create(bus);

            return CreatedAtAction(nameof(GetBuses), new { id = bus.Id },newBus);
        }


        [HttpPut]
        public async Task<ActionResult> PutBuses(int id, [FromBody] Bus bus)
        {
            if (id != bus.Id)
                return BadRequest();

            await _busRepository.Update(bus);

            return NoContent();
        }

        [HttpGet(nameof(GetDrivers))]
        public async Task<IEnumerable<Driver>> GetDrivers()
        {
            return await _driverRepository.Get();
        }
    }
}
