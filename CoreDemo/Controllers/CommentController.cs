using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public PartialViewResult PartialViewCommnet()
		{
			return PartialView();	
		}

		[HttpPost]
		public PartialViewResult PartialViewCommnet(Comment p)
		{
			p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
		    p.BlogId = 7;
			cm.CommentAdd(p);	
			return PartialView();
		}
		public PartialViewResult CommentListByBlog(int id)
		{
			var values = cm.GetList(id); 	 
			return PartialView(values);	
		}    
	}
}
