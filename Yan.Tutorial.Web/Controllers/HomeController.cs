using System;
using Microsoft.AspNetCore.Mvc;

namespace Yan.Tutorial.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => Content("Hello World yan");

        public IActionResult Time()
        {
            ViewBag.ServerTime = DateTime.Now;
            return View("Time");
        }
    }
}