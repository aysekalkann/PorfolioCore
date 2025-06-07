using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class ConnectController : Controller
    {
		PortfolioContext context = new PortfolioContext();

		public IActionResult Index()
		{
			var values = context.Connects.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult UpdateConnect(int id)
		{
			var value = context.Connects.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateConnect(Connect connect)
		{
			context.Connects.Update(connect);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}