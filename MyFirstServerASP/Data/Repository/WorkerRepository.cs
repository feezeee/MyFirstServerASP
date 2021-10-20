using Microsoft.EntityFrameworkCore;
using MyFirstServerASP.Data.Interfaces;
using MyFirstServerASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstServerASP.Data.Repository
{
    public class WorkerRepository : IWorkers
    {
        private readonly AppDBContent _appDBContent;

        public WorkerRepository (AppDBContent appDBContent)
        {
            this._appDBContent = appDBContent;
        }


        public IEnumerable<Worker> Workers => _appDBContent.Worker.Include(c => c.position);

        public Worker GetWorkerOfId(int id) => _appDBContent.Worker.FirstOrDefault(p => p.id == id);

        public IEnumerable<Worker> GetWorkersOfFirstName(string firstName) => _appDBContent.Worker.Where(p => p.firstName == firstName).Include(c => c.position);
        

        public IEnumerable<Worker> GetWorkersOfLastName(string lastName) => _appDBContent.Worker.Where(p => p.lastName == lastName).Include(c => c.position);

    }
}
