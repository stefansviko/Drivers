using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drivers.Models
{
    public class Bus
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string Registration { get; set; }

        public List<Driver> Drivers { get; set; } = new List<Driver>();
    }
}
