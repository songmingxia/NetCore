using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace helloworld
{
    public class HomeController : Controller
    {
        [HttpGet("/{name}")]
        //public string Index(string name)
        //{
        //    return $"Hello {name}";
        //}
        public IActionResult Index(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}
