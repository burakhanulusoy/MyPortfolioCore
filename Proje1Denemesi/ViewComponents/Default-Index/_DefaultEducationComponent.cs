using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultEducationComponent(PortfolioContext context):ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = context.Educations.ToList();
            return View(values);
        }
    }
}
