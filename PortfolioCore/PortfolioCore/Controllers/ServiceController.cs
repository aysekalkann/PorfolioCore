using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
    public class ServiceController : Controller
    {
        PortfolioContext context=new PortfolioContext();    
        public IActionResult ServiceList()
        {
            var values = context.Services.ToList();
            return View(values);
        }
    }
}
