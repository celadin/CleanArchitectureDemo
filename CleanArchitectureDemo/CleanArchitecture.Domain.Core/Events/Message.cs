using MediatR;

namespace CleanArchitecture.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        protected Message()
        {
            CommandName = GetType().Name;
        }

        public string CommandName { get; protected set; }
    }
}