using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStaticComponentPartial:ViewComponent
    {
        PortfolioContext Context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = Context.Skills.Count();
            ViewBag.v2 = Context.Portfolios.Count();
            ViewBag.v3 = Context.Messages.Count();
            Random random = new Random();
            ViewBag.v4 = random.Next(10, 30);
            return View();

        }
    }

}
