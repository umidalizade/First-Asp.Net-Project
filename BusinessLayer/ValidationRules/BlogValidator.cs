using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Title can not be empty!");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog Content can not be empty!");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Image can not be empty!");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Blog title can not be less than 5 characters");
            RuleFor(x => x.BlogTitle).MaximumLength(250).WithMessage("Blog Title can not be much more than 300 characters");
        }
    }
}
