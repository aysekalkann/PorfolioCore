﻿using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultAboutComponentPartial:ViewComponent
    {
        PortfolioContext context=new PortfolioContext();    
        public IViewComponentResult Invoke()
        {
            var value=context.Abouts.ToList();
            return View(value); 
        }
    }
}
