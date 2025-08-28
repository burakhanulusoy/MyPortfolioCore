using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;

namespace Proje1Denemesi.ViewComponents.Default_Index
{
    public class _DefaultContactComponent(PortfolioContext context) : ViewComponent
    {


        public IViewComponentResult Invoke()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }


    }
}