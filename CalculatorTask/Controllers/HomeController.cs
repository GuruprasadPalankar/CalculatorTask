using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalculatorTask.Models;
using CalculatorLogic;

namespace CalculatorTask.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogic _logic;

        public HomeController(ILogic logic)
        {
            this._logic = logic;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Display(NumbersModel model, string operation)
        {
            if (ModelState.IsValid)
            {
                model.Solution = this._logic.SolutionPart(model.Number1, model.Number2, operation);
            }
            return View("Index", model);
        }
    }
}