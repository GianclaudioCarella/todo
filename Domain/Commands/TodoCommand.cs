using Domain.Enum;
using Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public abstract class TodoCommand : ICommand
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public TodoState State { get; set; }
        public string File { get; set; }

        public abstract bool IsValid();
    }
}
