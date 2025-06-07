using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
    public class EducationController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult EducationList()
        {
            var values = context.Educations.ToList();
            return View(values);
        }
    }
}
