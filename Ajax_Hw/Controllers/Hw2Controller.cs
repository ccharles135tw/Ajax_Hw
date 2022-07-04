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
        public IActionResult check(Member mem)
        {
            var a = _democontext.Members.FirstOrDefault(x => x.Name == mem.Name);
            if (a != null)
            {
                return Content($"{mem.Name}已被使用。", "text/html", System.Text.Encoding.UTF8);
            }
            else
            {
                return Content($"{mem.Name}可以使用。", "text/html", System.Text.Encoding.UTF8);
            }
            
        }
    }
}
