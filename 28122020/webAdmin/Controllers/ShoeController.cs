using Bus.Controller;
using Dao.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using webAdmin.Models;

namespace webAdmin.Controllers
{
    public class ShoeController : Controller
    {
        private readonly ILogger<ShoeController> _logger;
        private readonly ShoeBus _shoeBus;
        private readonly IHostingEnvironment _hostingEnvironment;

        public ShoeController(ILogger<ShoeController> logger, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _shoeBus = new ShoeBus();
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            ViewBag.Shoes = _shoeBus.GetShoes();
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ViewShoeModelAdd shoeModelAdd)
        {
            if (!ModelState.IsValid)
                return View();

            string imgPath = "";
            if (shoeModelAdd.ShoeImg != null)
            {
                //Cach 1
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");

                if (!System.IO.File.Exists(uploadsFolder))
                    Directory.CreateDirectory(uploadsFolder);

                imgPath = Guid.NewGuid().ToString() + "_" + shoeModelAdd.ShoeImg.FileName;

                string path = Path.Combine(uploadsFolder, imgPath);
                shoeModelAdd.ShoeImg.CopyTo(new FileStream(path, FileMode.Create));

                //Cach 2 
                //[ADD]
                //
                //[END]
            }

            var shoeadd = new ShoeModel
            {
                ShoeName = shoeModelAdd.ShoeName,
                ShoeImg = imgPath
            };


            var req = _shoeBus.Add(shoeadd);
            if (req.stt != -1)
            {
                return RedirectToAction("Index");
                //message
            }

            return View(shoeModelAdd);
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
