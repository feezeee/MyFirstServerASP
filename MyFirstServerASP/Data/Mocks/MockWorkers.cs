using MyFirstServerASP.Data.Interfaces;
using MyFirstServerASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstServerASP.Data.Mocks
{
    public class MockWorkers : IWorkers
    {
        private readonly IWorkerPosition _positionWorkers = new MockPosition();
        public IEnumerable<Worker> Workers
        { 
            get
            {
                return new List<Worker>
                {
                    new Worker { firstName = "Максим", lastName = "Сащеко", position = _positionWorkers.Positions.Last() },
                    new Worker { firstName = "Денис", lastName = "Скурат", position = _positionWorkers.Positions.First() }
                };
            }
        }

        public Worker GetWorkerOfId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Worker> GetWorkersOfFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Worker> GetWorkersOfLastName(string lastName)
        {
            throw new NotImplementedException();
        }
    }
}
