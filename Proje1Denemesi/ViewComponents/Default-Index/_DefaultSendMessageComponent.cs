using Microsoft.AspNetCore.Mvc;
using Proje1Denemesi.Context;

namespace Proje1Denemesi.ViewComponents.Default_Index
{
    public class _DefaultSendMessageComponent(PortfolioContext context):ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }


    }
}
