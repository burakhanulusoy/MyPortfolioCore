using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;
using Proje1Denemesi.Entities;

namespace Portfolio.Web.Controllers
{
    public class SkillController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values=context.Skills.ToList();
            return View(values);
        }
        public IActionResult AddSkill()
        {

            return View();

        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {

            if(!ModelState.IsValid)
            {
                return View(skill);
            }

            context.Skills.Add(skill);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var value = context.Skills.Find(id);
            context.Skills.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }


        public IActionResult UpdateSkill(int id)
        {
            var value=context.Skills.Find(id);
            return View(value);

        }
        [HttpPost]  
        public IActionResult UpdateSkill(Skill skill)
        {
            if (!ModelState.IsValid)
            {
                return View(skill);
            }


            context.Skills.Update(skill);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
