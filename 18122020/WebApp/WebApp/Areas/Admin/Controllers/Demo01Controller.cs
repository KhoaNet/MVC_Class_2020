using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Area("Admin")]
    [Route("Admin/Demo01")]
    public class Demo01Controller : Controller
    {
        private readonly ILogger<Demo01Controller> _logger;

        public Demo01Controller(ILogger<Demo01Controller> logger)
        {
            //_logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
