using Domain.Commands;
using Domain.Entities;
using Domain.Repositories;
using Shared.Commands;

namespace Domain.Handlers
{
    public class TodoHandler : 
        ICommandHandler<RegisterNewTodoCommand>, 
        ICommandHandler<UpdateTodoCommand>,
        ITodoHandler
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

        public ICommandResult Handle(UpdateTodoCommand command)
        {
            if (!command.IsValid())
                return new CommandResult(false, "Invalid Todo");

            var todo = _repository.GetTodo(command.Id);
            todo.Description = command.Description;
            todo.State = command.State;
            todo.File = command.File;

            _repository.Update(todo);

            return new CommandResult(true, "Todo Updated");
        }
    }
}
