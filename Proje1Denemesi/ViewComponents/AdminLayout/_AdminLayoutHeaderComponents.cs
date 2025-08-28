using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;

namespace Proje1Denemesi.ViewComponents.AdminLayout
{
    public class _AdminLayoutHeaderComponents(PortfolioContext context):ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.username = HttpContext.Session.GetString("UserName");
            var values =context.UserMessages.ToList();
            return View(values);
        }




    }
}
