using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;
using Proje1Denemesi.Entities;

namespace Portfolio.Web.Controllers
{
    public class AboutController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values=context.Abouts.ToList();
            return View(values);
        }

        public IActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            if (!ModelState.IsValid) { 
            return View(about);
            
            }

            context.Abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction("Index");


        }

        public IActionResult RemoveAbout(int id)
        {
            var value= context.Abouts.Find(id);
            context.Abouts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {

            if (!ModelState.IsValid)
            {
                return View(about);
            }

            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }









    }
}
