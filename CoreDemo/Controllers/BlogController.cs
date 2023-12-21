using BusinessLayer.Concreate;

using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogsListWithCategory();  
            return View(values);
        }

        public IActionResult BlogReadAll(int id) 
        {
            ViewBag.i = id; 
            var values = bm.GetBlogById(id);
            return View(values);  
        }


        
    }
}
