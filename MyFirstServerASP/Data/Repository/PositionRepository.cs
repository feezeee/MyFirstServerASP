using MyFirstServerASP.Data.Interfaces;
using MyFirstServerASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstServerASP.Data.Repository
{
    public class PositionRepository : IWorkerPosition
    {
        private readonly AppDBContent _appDBContent;

        public PositionRepository(AppDBContent appDBContent)
        {
            this._appDBContent = appDBContent;
        }
        public IEnumerable<Position> Positions => _appDBContent.Position;
    }
}
