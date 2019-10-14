using Domain.Enum;
using Domain.Validations;
using FluentValidation.Results;

namespace Domain.Commands
{
    public class UpdateTodoCommand : TodoCommand
    {
        public UpdateTodoCommand()
        {

        }

        public UpdateTodoCommand(string description, TodoState estado, string file)
        {
            Description = description;
            State = estado;
            File = file;
        }

        public override bool IsValid()
        {
            ValidationResult validationResult = new UpdateTodoCommandValidation().Validate(this);
            return validationResult.IsValid;
        }
    }
}
