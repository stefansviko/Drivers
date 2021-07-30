using Drivers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drivers.Repositories
{
    public class DriverRepository : IDriverRepository
    {
        private readonly BusContext _context;

        public DriverRepository(BusContext context)
        {
            _context = context;
        }

        public async Task<Driver> Create(Driver driver)
        {
            _context.Drivers.Add(driver);
            await _context.SaveChangesAsync();

            return driver;
        }

        public async Task Delete(int id)
        {
            var deleteBus = await _context.Drivers.FindAsync(id);

            _context.Drivers.Remove(deleteBus);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Driver>> Get()
        {
            return await _context.Drivers.ToListAsync();
        }

        public async Task<Driver> Get(int id)
        {
            return await _context.Drivers.FindAsync(id);
        }

        public async Task Update(Driver driver)
        {
            _context.Entry(driver).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
