using EntityLayer.Concrate;
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
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Writer's Name Surname can not be empty!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("E-mail place can not be empty!");
            RuleFor(x=>x.WriterPassword).NotEmpty().WithMessage("Password place can not be empty!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Name and Surname must be more than 2 characters!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Please, dont do character number more than 50!");
        }
    }
}
