﻿using Domain.Enum;
using Domain.Validations;
using FluentValidation.Results;

namespace Domain.Commands
{
    public class RegisterNewTodoCommand : TodoCommand
    {

        public RegisterNewTodoCommand()
        {
            
        }

        public RegisterNewTodoCommand(string description, TodoState estado, string file)
        {
            Description = description;
            State = estado;
            File = file;
        }

        public override bool IsValid()
        {
            ValidationResult validationResult = new RegisterNewTodoCommandValidation().Validate(this);
            return validationResult.IsValid;
        }
    }
}
