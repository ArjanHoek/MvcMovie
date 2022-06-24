using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // Every public method in a controller is callable as an HTTP endpoint
       
        // /HelloWorld/ > /Index/ is not required, since it is the default when no endpoint for this controller was given
        public IActionResult Index()
        {
            return View();
        }

        // /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}