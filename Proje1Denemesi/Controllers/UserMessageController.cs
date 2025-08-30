using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proje1Denemesi.Context;

namespace Portfolio.Web.Controllers
{
    public class UserMessageController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values=context.UserMessages.ToList();
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var msg = context.UserMessages.Find(id);
            if (msg != null)
            {
                context.UserMessages.Remove(msg);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult MessageRead(int id)
        {
            var msg = context.UserMessages.Find(id);
            if (msg != null)
            {
                msg.IsRead = true;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }



    }
}
