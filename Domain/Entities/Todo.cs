using Domain.Enum;
using Shared.Entities;

namespace Domain.Entities
{
    public class Todo : Entity
    {
        public Todo(string description, TodoState state, string file)
        {
            Description = description;
            State = state;
            File = file;
        }

        public string Description { get; set; }
        public TodoState State { get; set; }
        public string File { get; set; }
    }
}
