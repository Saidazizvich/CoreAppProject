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
	public class NewsLetterManager : INewsLetterService
	{
		INewsLetterDal _letterDal;

		public NewsLetterManager(INewsLetterDal letterDal)
		{
			_letterDal = letterDal;
		}

		public void AddNewsLetter(NewsLetter newsLetter)
		{
			_letterDal.Insert(newsLetter);	
		}
	}
}
