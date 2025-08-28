using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;
using Proje1Denemesi.Entities;

namespace Proje1Denemesi.Controllers
{
    [AllowAnonymous]
    public class DefaultController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(UserMessage userMessage)
        {
            context.UserMessages.Add(userMessage);
            context.SaveChanges();
            Task.Delay(3000).Wait();
            return RedirectToAction("Index");

        }



    }
}
