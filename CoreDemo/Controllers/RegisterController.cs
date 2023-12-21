using BusinessLayer.Concreate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wr = new WriterManager(new EfWriterRepository());

		 

		[HttpGet]
		public IActionResult Index()
		{
			 
			return View();
		}

		[HttpPost]
		public IActionResult Index(Writer writer) 
		{
			WriterValidator wv = new WriterValidator();
			ValidationResult results = wv.Validate(writer);
            if (results.IsValid)
            {
				writer.WriterStatus = true;
				writer.WriterAbout = "Deneme test";
				wr.AddWriter(writer);
				return RedirectToAction("Index", "Blog");
			}
            else
            {
                foreach(var item in results.Errors) 
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);	
				}
            }
			return View();	

        }

				 


	}
}
