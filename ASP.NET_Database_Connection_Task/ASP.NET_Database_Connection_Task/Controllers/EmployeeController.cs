using Microsoft.AspNetCore.Mvc;
using ASP.NET_Database_Connection_Task.Contexts;
using ASP.NET_Database_Connection_Task.Models;


namespace ASP.NET_Database_Connection_Task.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;
        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Employee> employees = _context.Employees.ToList();
            return View(employees);
        }
    }
}