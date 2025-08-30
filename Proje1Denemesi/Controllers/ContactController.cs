using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;
using Proje1Denemesi.Entities;

namespace Portfolio.Web.Controllers
{
    public class ContactController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values=context.Contacts.ToList();
            return View(values);
        }


        public IActionResult AddContact()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }


            context.Contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult RemoveContact(int id)
        {
            var value = context.Contacts.Find(id);
            context.Contacts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult UpdateContact(int id)
        {
            var value=context.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }
            context.Contacts.Update(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }





    }
}
