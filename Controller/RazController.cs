using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace RazorFun.Controllers
{
    public class RazController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            System.Console.WriteLine("This is Working");
            return View("Index");
        }
    }
}