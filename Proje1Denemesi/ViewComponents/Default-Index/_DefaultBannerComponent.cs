using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultBannerComponent(PortfolioContext context):ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values=context.Banners.ToList();
            return View(values);
        }
    }
}
