using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;
using Proje1Denemesi.Entities;

namespace Portfolio.Web.Controllers
{
    public class EducationController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values=context.Educations.ToList();
            return View(values);
        }
    
        public IActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEducation(Education education)
        {
            if (!ModelState.IsValid)
            {
                return View(education);
            }
            context.Educations.Add(education);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult DeleteEducation(int id)
        {
            var value=context.Educations.Find(id);
            context.Educations.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateEducation(int id)
        {
            var value = context.Educations.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateEducation(Education education)
        {
            if (!ModelState.IsValid)
            {
                return View(education);
            }
            context.Update(education);
            context.SaveChanges();
            return RedirectToAction("Index");



        }




    }
}
