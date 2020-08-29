using System;
using CleanArchitecture.Domain.Core.Events;

namespace CleanArchitecture.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public DateTime Timestamp { get; protected set; }
    }
}