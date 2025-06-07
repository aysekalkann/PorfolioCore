using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
    public class ExperienceController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult ExperienceLİst()
        {
            var values=context.Experiences.ToList();
            return View(values);
        }
    }
}
