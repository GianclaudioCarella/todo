using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/todo")]
    [ApiController]
    public class TodoController : Controller
    {
        private readonly IRepository _repository;

        public TodoController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("int:id")]
        public Todo Get(Guid id)
        {
            return _repository.GetTodo(id);
        }

        [HttpGet]
        public List<Todo> GetAll()
        {
            return _repository.GetTodos();
        }
    }
}