using Domain.Commands;
using Domain.Entities;
using Domain.Repositories;
using Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Handlers
{
    public class TodoHandler : ICommandHandler<RegisterNewTodoCommand>
    {
        private readonly IRepository _repository;

        public TodoHandler(IRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(RegisterNewTodoCommand command)
        {
            if (!command.IsValid())
                return new CommandResult(false, "Invalid Todo");

            var todo = new Todo(command.Description, command.State, command.File);

            _repository.CreateTodo(todo);

            return new CommandResult(true, "Todo Created");
        }
    }
}
