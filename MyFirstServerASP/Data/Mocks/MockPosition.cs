using MyFirstServerASP.Data.Interfaces;
using MyFirstServerASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstServerASP.Data.Mocks
{
    public class MockPosition : IWorkerPosition
    {
        public IEnumerable<Position> Positions 
        { 
            get
            {
                return new List<Position> 
                {
                    new Position {positionName="Директор"},
                    new Position {positionName="Кассир"}
                };
            }

            set
            {
                // smth
            }
        }
    }
}
