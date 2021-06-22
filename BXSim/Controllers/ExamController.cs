using BXSim.Data;
using BXSim.Models;
using BXSim.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BXSim.Controllers
{
    public class ExamController : Controller
    {
        private IExamRepo repository;
        public ExamController(IExamRepo repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bx900()
        {

            return View(new ExamControllerViewModel {
                Questions = repository.Questions.ShuffleItems() });
        }
        public IActionResult Bx104()
        {
            return View(repository.Scenarios.AsEnumerable().Reverse());
        }
    }
}
