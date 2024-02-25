using Microsoft.AspNetCore.Mvc;
namespace ASP.NET_Database_Connection_Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}