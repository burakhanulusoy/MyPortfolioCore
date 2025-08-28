using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proje1Denemesi.Context;

namespace Proje1Denemesi.ViewComponents.Default_Index
{
    public class _DefaultProjectComponent:ViewComponent
    {

        private readonly PortfolioContext _context;

        public _DefaultProjectComponent(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values=_context.Categories.Include(x=>x.Projects).ToList();
            return View(values);
        }
    }
}
