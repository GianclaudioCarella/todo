using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Validations
{
    public class RegisterNewTodoCommandValidation : TodoValidation<RegisterNewTodoCommand>
    {
        public RegisterNewTodoCommandValidation()
        {
            ValidationTodo();
        }
    }
}
