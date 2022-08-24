using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        //GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
            //return "Sapec, hello world. This is my deffaault action...";
        }

        //
        // GET: /HelloWorld/Welcome/
        // ruquires using Sysytem.Text.Encodings.Web;

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = $"Hello {name}";
            ViewData["NumTimes"] = numTimes;
            return View();
        }
        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"hi, {name}, NumTimes is: {ID}");
        //    //return "This is the Welcome action method...";
        //}
        //public string Welcome(string name, int numTimes)
        //{
        //    return HtmlEncoder.Default.Encode($"hi, {name}, NumTimes is: {numTimes}");
        //    //return "This is the Welcome action method...";
        //}
    }
}
