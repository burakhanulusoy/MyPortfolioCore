using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultExpreinceComponent(PortfolioContext context):ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var experiences = context.Expreinces.ToList();
            return View(experiences);
        }
    }
}
