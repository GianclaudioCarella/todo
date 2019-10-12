using Domain.Entities;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public interface IRepository
    {
        List<Todo> GetTodos();
        Todo GetTodo(Guid id);
        void CreateTodo(Todo todo);
        void ChangeStateTodo(Guid id, TodoState state);
    }
}
