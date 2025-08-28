using Microsoft.AspNetCore.Mvc;

namespace Proje1Denemesi.ViewComponents.AdminLayout
{
    public class _AdminLayoutSideBarComponents:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }


    }
}
