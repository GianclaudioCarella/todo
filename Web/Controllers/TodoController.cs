using System;
using System.Collections.Generic;
using Domain.Commands;
using Domain.Entities;
using Domain.Handlers;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/todo")]
    [ApiController]
    public class TodoController : Controller
    {
        private readonly IRepository _repository;
        private readonly ITodoHandler _handler;

        public TodoController(IRepository repository, ITodoHandler handler)
        {
            _handler = handler;
            _repository = repository;
        }

        [HttpGet("int:id")]
        public Todo Get(Guid id)
        {
            return _repository.GetTodo(id);
        }

        [HttpGet("pending")]
        public List<Todo> GetAllPending()
        {
            return _repository.GetPendingTodos();
        }

        [HttpGet]
        public List<Todo> GetAll()
        {
            return _repository.GetTodos();
        }

        [HttpPut]
        public ActionResult Put([FromBody]UpdateTodoCommand command)
        {
            try
            {
                _handler.Handle(command);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody]RegisterNewTodoCommand command)
        {
            try
            {
                _handler.Handle(command);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}