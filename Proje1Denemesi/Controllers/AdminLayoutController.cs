using Microsoft.AspNetCore.Mvc;

namespace Proje1Denemesi.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Layout()
        {
            return View();
        }
    }
}
