using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Comment
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentList = new List<UserComment>
            {
                new UserComment
                {
                     Id = 1,
                     Username = "Cem"
                },

                new UserComment
                {
                    Id = 2,
                    Username = "Derya"
                },

                new UserComment
                {
                    Id = 3,
                    Username = "Fatih"
                }
            };
            return View(commentList);
        }
    }
}
