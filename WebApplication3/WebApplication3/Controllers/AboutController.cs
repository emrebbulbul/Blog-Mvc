﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
	public class AboutController : Controller
	{
		AboutManager abm = new AboutManager(new EfAbaoutRepository());
		public IActionResult Index()
		{
			var values = abm.GetList();
			return View(values);
		}
		public PartialViewResult SocialMediaAbout()
		{
			return PartialView();

		}
	}
}
