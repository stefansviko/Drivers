using Drivers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drivers.Repositories
{
    public interface IBusRepository
    {
        Task<IEnumerable<Bus>> Get();

        Task<Bus> Get(int id);

        Task<Bus> Create(Bus bus);

        Task Update(Bus bus);

        Task Delete(int id);
    }
}
