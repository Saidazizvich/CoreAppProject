using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adi soyadi kismi bos gecilemez");
            RuleFor(x => x.WritterPassword).NotEmpty().WithMessage("Sifre bos gecilemez");
			
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lutfen iki harakter girinz");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lutfen en az 2 karakter girisi yap");

        }
    }
}
