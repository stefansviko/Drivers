using Drivers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drivers.Repositories
{
    public class BusRepository : IBusRepository
    {
        public readonly BusContext _context;

        public BusRepository(BusContext context)
        {
            _context = context;
        }

        public async Task<Bus> Create(Bus bus)
        {
            _context.Buses.Add(bus);

            await _context.SaveChangesAsync();

            return bus;
        }

        public async Task Delete(int id)
        {
            var bus = await _context.Buses.FindAsync(id);
            _context.Buses.Remove(bus);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Bus>> Get()
        {
            return await _context.Buses.ToListAsync();
        }

        public async Task<Bus> Get(int id)
        {
            return await _context.Buses.FindAsync(id);
        }

        public async Task Update(Bus bus)
        {
            _context.Entry(bus).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
