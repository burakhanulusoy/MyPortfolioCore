using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultSkillComponent(PortfolioContext context):ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
