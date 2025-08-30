using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;
using Proje1Denemesi.Entities;

namespace Portfolio.Web.Controllers
{
    public class TestimonialController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            
            var values=context.Testimonials.ToList();
            return View(values);

        }

        public IActionResult AddTestimonial()
        {
            return View();
        }




        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {

              if (!ModelState.IsValid)
              {
                return View(testimonial);
              }



             context.Testimonials.Add(testimonial);
             context.SaveChanges();
             return RedirectToAction("Index");
        
        }

        public IActionResult UpdateTestimonial(int id)
        {
            var values = context.Testimonials.Find(id);
            return View(values);
        }


        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {

            if (!ModelState.IsValid)
            {
                return View(testimonial);
            }


            context.Testimonials.Update(testimonial);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }





    }
}
