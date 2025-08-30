using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Entities;
using Proje1Denemesi.Context;

namespace Portfolio.Web.Controllers
{
    public class UserController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values=context.Users.ToList();
            return View(values);
        }

        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            context.Users.Add(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteUser(int id)
        {
            var user=context.Users.Find(id);
            context.Users.Remove(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult UpdateUser(int id)
        {
            var value=context.Users.Find(id);
            return View(value);
        }



        [HttpPost]
        public IActionResult UpdateUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            context.Users.Update(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
