using Ajax_Hw.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajax_Hw.Controllers
{
    public class Hw2Controller : Controller
    {
        private readonly DemoContext _democontext;

        public Hw2Controller(DemoContext democontext)
        {
            _democontext = democontext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult check(string name)
        {
            var a = _democontext.Members.FirstOrDefault(x => x.Name == name);
            if (a != null)
            {
                return Content($"{name}已被使用。", "text/html", System.Text.Encoding.UTF8);
            }
            else
            {
                return Content($"{name}可以使用。", "text/html", System.Text.Encoding.UTF8);
            }
            
        }
    }
}
