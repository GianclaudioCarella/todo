using Domain.Commands;
using Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Handlers
{
    public interface ITodoHandler
    {
        ICommandResult Handle(RegisterNewTodoCommand command);
        ICommandResult Handle(UpdateTodoCommand command);
    }
}
