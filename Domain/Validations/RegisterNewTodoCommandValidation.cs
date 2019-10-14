using Domain.Commands;

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
