﻿using h32.Models;
using h32.Data;

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace h32.Controllers
{
    
    public class HomeController : Controller
    {
        h32Context cxt = new h32Context();
        private readonly ILogger<HomeController> _logger;

        
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Add()
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