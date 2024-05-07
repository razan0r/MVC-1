using Microsoft.AspNetCore.Mvc;
using task1.Data;

namespace task1.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context =new ApplicationDbContext();
        public IActionResult Index()
        {
            var employees=context.Employees.ToList();
            return View("create", employees);
        }
    }
}
