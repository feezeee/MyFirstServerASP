using MyFirstServerASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstServerASP.Data.Interfaces
{
    public interface IWorkers
    {
        IEnumerable<Worker> Workers { get; }

        IEnumerable<Worker> GetWorkersOfFirstName(string firstName);
        IEnumerable<Worker> GetWorkersOfLastName(string lastName);
        Worker GetWorkerOfId(int id);
    }
}
