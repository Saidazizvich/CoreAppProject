using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class ContactController : Controller
	{
		ContactManager cm = new ContactManager(new EfContactRepository());	

		[HttpGet]	
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index1(Contact po)
		{
			po.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			po.ContactStatus = true;
			cm.ContactAdd(po);

			return RedirectToAction("Index","Blog");
		}
	}
}
