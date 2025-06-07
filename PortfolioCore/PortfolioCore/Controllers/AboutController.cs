using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
    public class AboutController : Controller
    {
        PortfolioContext context=new PortfolioContext();    
        public IActionResult AboutList()
        {
            var values=context.Abouts.ToList();
            return View(values);
        }
    }
}
