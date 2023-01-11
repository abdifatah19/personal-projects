using Microsoft.AspNetCore.Mvc;
using Clinic_Application.Models;


namespace Clinic_Application.Controllers
{
    public class HomeController : Controller
    {
        [Route("/patient")]
        public IActionResult Index(String? Firstname, String? LastName)
        {
            return View();
        }
    }
}
