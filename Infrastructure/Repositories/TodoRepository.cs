using Domain.Entities;
using Domain.Enum;
using Domain.Repositories;
using Infrastructure.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repositories
{
    public class TodoRepository : IRepository
    {
        private readonly TodoDbContext _context;
        public TodoRepository(TodoDbContext context)
        {
            _context = context;
        }

        public async void ChangeStateTodo(Guid id, TodoState state)
        {
            var todo = _context.Todo.Where(t => t.Id.Equals(id)).FirstOrDefault();
            todo.State = state;
            await _context.SaveChangesAsync();
        }

        public async void CreateTodo(Todo todo)
        {
            _context.Add(todo);
            await _context.SaveChangesAsync();
        }

        public Todo GetTodo(Guid id)
        {
            return _context.Todo.Find(id);
        }

        public List<Todo> GetTodos()
        {
            return _context.Todo.ToList();
        }

        public List<Todo> GetPendingTodos()
        {
            return _context.Todo.Where(t => t.State.Equals(TodoState.Created)).ToList();
        }

        public async void Update(Todo todo)
        {
            var pobjTodo = _context.Todo.Update(todo);
            await _context.SaveChangesAsync();
        }
    }
}
