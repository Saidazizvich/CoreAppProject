 using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void AddBlog(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogById(int id) 
		{
			return _blogDal.GetListAll(x=>x.BlogId == id);	
		}

		public List<Blog> GetAllList()
		{
			return _blogDal.GetListAll();	
		}

		public List<Blog> GetBlogsListWithCategory()
		{
			return _blogDal.GetListWithCategory();
		}

		public Blog GetBlogyById(int id)
		{
			throw new NotImplementedException();

        }

		public List<Blog> GetBlogListByWriter(int id)
		{
			return _blogDal.GetListAll(x=>x.WriterId == id);	
		}
	}
}
