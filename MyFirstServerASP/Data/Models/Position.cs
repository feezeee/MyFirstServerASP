using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstServerASP.Data.Models
{
    public class Position
    {
        public int id { get; set; }

        public string positionName { get; set; }

        public List<Worker> workers { get; set; }

    }
}
