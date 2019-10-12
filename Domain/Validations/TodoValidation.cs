using Domain.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Validations
{
    public abstract class TodoValidation<T> : AbstractValidator<T> where T : TodoCommand
    {
        public TodoValidation()
        {
            RuleFor(c => c.Description)
                .NotEmpty()
                .WithMessage("Todo needs a description");
        }


        public void ValidationTodo()
        {
            RuleFor(c => c.Description)
                .MaximumLength(20)
                .WithMessage("The max length for todo description is 20.");
        }

        protected void ValidateId()
        {
            RuleFor(c => c.Id).NotEqual(Guid.Empty);
        }



    }


}
