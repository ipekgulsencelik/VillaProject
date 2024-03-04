using FluentValidation;
using Villa.Entity.Entities;

namespace Villa.Business.Validations.QuestionValidation
{
    public class QuestionValidator : AbstractValidator<FrequentlyQuestion>
    {
        public QuestionValidator() 
        {
            RuleFor(x => x.Question).NotEmpty().WithMessage("Soru Alanı Boş Bırakılamaz!..");
            RuleFor(x => x.Question).MinimumLength(10).WithMessage("En Az 10 Karakter Uzunluğunda Bir Soru Verisi Girişi Yapınız!..");
            RuleFor(x => x.Question).MaximumLength(200).WithMessage("En Fazla 200 Karakter Uzunluğunda Bir Soru Verisi Girişi Yapınız!..");
            RuleFor(x => x.Answer).NotEmpty().WithMessage("Cevap Alanı Boş Bırakılamaz!..");
            RuleFor(x => x.Answer).MinimumLength(10).WithMessage("En Az 10 Karakter Uzunluğunda Bir Cevap Verisi Girişi Yapınız!..");
            RuleFor(x => x.Answer).MaximumLength(200).WithMessage("En Fazla 200 Karakter Uzunluğunda Bir Cevap Verisi Girişi Yapınız!..");
        }
    }
}