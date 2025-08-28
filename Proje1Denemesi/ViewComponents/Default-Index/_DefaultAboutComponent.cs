using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;
using System.Reflection.Metadata.Ecma335;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultAboutComponent(PortfolioContext context) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
    }
}
