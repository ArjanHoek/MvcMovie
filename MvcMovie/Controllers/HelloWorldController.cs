using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // Every public method in a controller is callable as an HTTP endpoint
       
        // /HelloWorld/ > /Index/ is not required, since it is the default when no endpoint for this controller was given
        public string Index()
        {
            return "This is my default action...";
        }

        // /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");

        }
    }
}