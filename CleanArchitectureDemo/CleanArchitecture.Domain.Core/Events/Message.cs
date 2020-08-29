using MediatR;

namespace CleanArchitecture.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        protected Message()
        {
            Name = GetType().Name;
        }

        public string Name { get; protected set; }
    }
}