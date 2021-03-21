using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace hello_world.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<HelloWorld>/
        public IActionResult Index(string userInput = "World")
        {
            ViewData["userInput"] = userInput + "!";

            return View();
        }
    }
}
