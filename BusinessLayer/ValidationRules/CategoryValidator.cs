using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category Name can not be empty!");
            RuleFor(x => x.CategoryDesc).NotEmpty().WithMessage("Category Description can not be empty!");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("The carachters length of Category name less than 50!");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("The carachters length of Category name more than 2!");
        }
    }
}
