using Bus.Controller;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using webClient.Models;

namespace webClient.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly EmployeeBus _empBus;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
            _empBus = new EmployeeBus();
        }

        public IActionResult Index()
        {
            var lst = _empBus.GetEmployees();
            ViewBag.Employees = lst;
            return View();
        }
    }
}
