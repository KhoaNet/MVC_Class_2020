using Bus.Controller;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using webAdmin.Models;

namespace webAdmin.Controllers
{
    public class ShoeController : Controller
    {
        private readonly ILogger<ShoeController> _logger;
        private readonly ShoeBus _shoeRepo;

        public ShoeController(ILogger<ShoeController> logger)
        {
            _logger = logger;
            _shoeRepo = new ShoeBus();
        }

        public IActionResult Index()
        {
            ViewBag.Shoes = _shoeRepo.GetList();
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
