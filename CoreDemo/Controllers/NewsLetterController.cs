using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class NewsLetterController : Controller
	{
		NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());

		[HttpGet]	
		public PartialViewResult SubscripeMail()
		{
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult SubscripeMail(NewsLetter news)
		{
			news.MailStatus = true;
			nm.AddNewsLetter(news);
			return PartialView();
		}
	}
}
