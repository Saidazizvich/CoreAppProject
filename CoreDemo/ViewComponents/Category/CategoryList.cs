﻿using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Category
{
	public class CategoryList : ViewComponent 
	{
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());

		public IViewComponentResult Invoke()
		{
	        var values = cm.GetAllList();	 		 
			return View(values);	
		}		 
	}
}
