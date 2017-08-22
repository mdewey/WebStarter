using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStarter.Models;

namespace WebStarter.Controllers
{
    public class SamplesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*
            app.get("/greeting", (req, res) =>{
                res.send("hello there !");
            })
        
         */

        public string Greeting(string name)
        {
            return $"Hello there, {name}";
        }

        public IActionResult SignBirthdayCard()
        {
            return View();   
        }


        [HttpPost]
        public IActionResult SignBirthdayCard(string signature)
        {
            Console.WriteLine("got sig- " + signature);
            ViewData["lastSig"] = signature;
            return View();
        }


        [HttpGet]
        public IActionResult BookStore()
        {
            return View(new BookStoreViewModel() {StoreName = "B & N"});
        }

    }
}
