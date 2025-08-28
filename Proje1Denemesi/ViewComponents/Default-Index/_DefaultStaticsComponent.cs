using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultStaticsComponent(PortfolioContext context) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.static1=context.Projects.Count();
            ViewBag.static2=context.Expreinces.Count();
            ViewBag.static3=context.Skills.Count();
            ViewBag.static4=context.Testimonials.Count();

            return View();
        }
    }
}