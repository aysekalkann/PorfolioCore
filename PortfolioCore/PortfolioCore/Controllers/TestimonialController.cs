using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class TestimonialController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult TestimonialList()
        {
            var values=context.Testimonial.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            context.Testimonial.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var values = context.Testimonial.Find(id);
            context.Testimonial.Remove(values);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value=context.Testimonial.Find(id);    
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            context.Testimonial.Update(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        

    }
}
