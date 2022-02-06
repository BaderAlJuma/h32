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
            var cities = new List<string>(){
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };
            
                
            
            return View(cities);
        }

    }
}