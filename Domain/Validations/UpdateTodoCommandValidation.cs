using Domain.Commands;

namespace Domain.Validations
{
    public class UpdateTodoCommandValidation : TodoValidation<UpdateTodoCommand>
    {
        public UpdateTodoCommandValidation()
        {
            ValidationTodo();
        }
    }
}
