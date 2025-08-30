using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;
using Proje1Denemesi.Entities;

namespace Portfolio.Web.Controllers
{
    public class BannerController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values = context.Banners.ToList();
            return View(values);
        }

        public IActionResult AddBanner()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBanner(Banner banner)
        {
            if(!ModelState.IsValid)
            {
                return View(banner);
            }

            context.Banners.Add(banner);
            context.SaveChanges();
            return RedirectToAction("Index");


        }

        public IActionResult DeleteBanner(int id)
        {
            var value=context.Banners.Find(id);
            context.Banners.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateBanner(int id)
        {
            var value = context.Banners.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateBanner(Banner banner)
        {
            if (!ModelState.IsValid)
            {
                return View(banner);
            }

            context.Banners.Update(banner);
            context.SaveChanges();
            return RedirectToAction("Index");


        }









    }
}
