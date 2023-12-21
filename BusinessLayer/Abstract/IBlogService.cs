using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		void AddBlog(Blog blog);

		void BlogDelete(Blog blog);

		void BlogUpdate(Blog blog);

		List<Blog> GetAllList();

		Blog GetBlogyById(int id);

		List<Blog> GetBlogsListWithCategory();

		List<Blog> GetBlogListByWriter(int id);

	}
}
