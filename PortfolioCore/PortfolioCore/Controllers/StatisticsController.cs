using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Skills.Sum(x => x.SkillValue);
            ViewBag.v3 = context.Skills.Average(x=>x.SkillValue);
            ViewBag.v4=context.Skills.Where(x=>x.SkillValue>80).Count();
            ViewBag.v5=context.Skills.Where(x=>x.SkillValue<80).Count();
            ViewBag.v6=context.Messages.Count();
            ViewBag.v7=context.Experiences.Count();
            ViewBag.v8=context.Services.Count();
            ViewBag.v9 = context.Messages.Count(x => !x.IsRead);
            ViewBag.v10 = context.Messages.Count(x => x.IsRead);

            return View();
        }
    }
}
