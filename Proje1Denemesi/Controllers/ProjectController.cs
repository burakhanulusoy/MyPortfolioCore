using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proje1Denemesi.Context;
using Proje1Denemesi.Entities;

namespace Proje1Denemesi.Controllers
{
    public class ProjectController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var project = context.Projects.Include(x => x.Category).ToList();
            return View(project);
        }

        private void method()
        {
            var categories = context.Categories.ToList();

            ViewBag.Categories = (from x in categories
                                  select new SelectListItem
                                  {
                                      Text = x.CategoryName,
                                      Value = x.CategoryId.ToString()
                                  }).ToList();


        }


        public IActionResult AddProject()
        {
            method();
            return View();
        }

        [HttpPost]
        public IActionResult AddProject(Project project)
        {
            method();

            if (!ModelState.IsValid)
            {

                return View(project);

            }
            context.Projects.Add(project);
            context.SaveChanges();
            return RedirectToAction("Index");



        }


        public IActionResult DeleteProject(int id)
        {
            var project = context.Projects.Find(id);
            context.Remove(project);
            context.SaveChanges();
            return RedirectToAction("Index");
        }





        public IActionResult UpdateProject(int id)
        {
            method();
            var project = context.Projects.Find(id);
            return View(project);
        }
        [HttpPost]
        public IActionResult UpdateProject(Project project)
        {

            method();
            if (!ModelState.IsValid)
            {
                return View(project);
            }
            context.Projects.Update(project);
            context.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}