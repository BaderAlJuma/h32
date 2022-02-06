using h32.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace h32.Controllers
{
    public class HomeController1 : Controller
    {
        // 
        // GET: /HelloWorld/
        
        public IActionResult Index()
        {
            
            
                
            
            return View();
        }
        public IActionResult AddItem()
        {
            var cities = new Cart();




            return View(cities);
        }
    }
}