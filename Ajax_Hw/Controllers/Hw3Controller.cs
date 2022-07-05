using Ajax_Hw.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajax_Hw.Controllers
{
    public class Hw3Controller : Controller
    {
        private readonly DemoContext _democontext;

        public Hw3Controller(DemoContext democontext)
        {
            _democontext = democontext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult City()
        {
            var cities = _democontext.Addresses.Select(a => a.City).Distinct();
            return Json(cities);
        }
        public IActionResult Districts(string city)
        {
            var districts = _democontext.Addresses.Where(a => a.City == city).Select(a => a.SiteId).Distinct();
            return Json(districts);
        }
        public IActionResult Roads(string district)
        {
            var roads = _democontext.Addresses.Where(a => a.SiteId == district).Select(a => a.Road);
            return Json(roads);
        }
        public IActionResult Address()
        {
            return View();
        }
    }
}
