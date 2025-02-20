using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ManagerController : Controller
    {

        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Manager(int managerID)
        {
            ManagerRepository obj= new ManagerRepository();
            ManagerController managerDetails = obj.GetManagerById(managerID);
            return View(managerDetails);
        }
    }
}
