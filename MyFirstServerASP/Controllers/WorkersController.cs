using Microsoft.AspNetCore.Mvc;
using MyFirstServerASP.Data.Interfaces;
using MyFirstServerASP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstServerASP.Controllers
{
    public class WorkersController : Controller
    {
        private readonly IWorkers _workers;
        private readonly IWorkerPosition _allPositions;


        public WorkersController(IWorkers workers, IWorkerPosition workerPosition)
        {
            _workers = workers;
            _allPositions = workerPosition;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Работники";
            WorkersListViewModel obj = new WorkersListViewModel();
            obj.AllWorkers = _workers.Workers;
            return View(obj);
        }
    }
}
