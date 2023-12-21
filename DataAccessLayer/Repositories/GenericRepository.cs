using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var con = new Context();
              con.Remove(t);    
              con.SaveChanges();
        }

        public T GetById(int id)
        {
            using var con = new Context();
            return con.Set<>().ToList    
        }

        public List<T> GetListAll()
        {
            using var con = new Context();
             return con.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var con = new Context();
            con.Add(t);
            con.SaveChanges();
        }

		public List<T> GetListAll(Expression<Func<T, bool>> filter)
		{
            using var c = new Context();
			return c.Set<T>().Where(filter).ToList();
		}

		public void Update(T t)
        {
            using var con = new Context();
            con.Update(t);
            con.SaveChanges();
        }
    }
    
}
