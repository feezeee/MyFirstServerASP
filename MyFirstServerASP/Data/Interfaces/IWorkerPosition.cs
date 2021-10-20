using MyFirstServerASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstServerASP.Data.Interfaces
{
    public interface IWorkerPosition
    {
        IEnumerable<Position> Positions { get; }
    }
}
