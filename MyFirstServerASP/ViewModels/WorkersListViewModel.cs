using MyFirstServerASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstServerASP.ViewModels
{
    public class WorkersListViewModel
    {
        public IEnumerable<Worker> AllWorkers { get; set; }        


    }
}
