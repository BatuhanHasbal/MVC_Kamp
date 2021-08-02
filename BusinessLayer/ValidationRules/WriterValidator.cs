using EntityLayer.Concrete;
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
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı boş geçilemez.");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadı boş geçiremez.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar ünvan kısmı boş geçiremez.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("50 karakter üzerinde yazmayınız");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında kısmı boş geçilemez.");


        }
    }
}
