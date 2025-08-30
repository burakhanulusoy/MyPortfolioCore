using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;
using Proje1Denemesi.Entities;

namespace Portfolio.Web.Controllers
{
    public class ExpreinceController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values=context.Expreinces.ToList();
            return View(values);
        }

        public IActionResult AddExpreince()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExpreince(Expreince expreince)
        {
            if (!ModelState.IsValid)
            {
                return View(expreince);
            }
            context.Expreinces.Add(expreince);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExpreince(int id)
        {
            var value = context.Expreinces.Find(id);
            context.Expreinces.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult UpdateExpreince(int id)
        {
            var value = context.Expreinces.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExpreince(Expreince expreince)
        {
           if(!ModelState.IsValid)
            {
                return View(expreince);
            }

            context.Update(expreince);
            context.SaveChanges();
            return RedirectToAction("Index");



        }






    }
}
