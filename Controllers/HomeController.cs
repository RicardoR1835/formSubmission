using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using formSubmission.Models;

namespace formSubmission.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(User user)
        {
            if(ModelState.IsValid){
                return RedirectToAction("show");
            }
            else{
                return View("Index");
            }
        }

        [HttpGet("show")]
        public IActionResult Show()
        {
            return View("Show");
        }

    }
}
