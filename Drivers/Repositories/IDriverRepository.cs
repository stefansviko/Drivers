using Drivers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drivers.Repositories
{
    public interface IDriverRepository
    {
        Task<IEnumerable<Driver>> Get();

        Task<Driver> Get(int id);

        Task<Driver> Create(Driver driver);

        Task Update(Driver driver);

        Task Delete(int id);
    }
}
