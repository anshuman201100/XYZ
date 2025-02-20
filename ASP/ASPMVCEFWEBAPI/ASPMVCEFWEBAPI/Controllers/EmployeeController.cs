using Microsoft.AspNetCore.Mvc;

namespace ASPMVCEFWEBAPI.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
