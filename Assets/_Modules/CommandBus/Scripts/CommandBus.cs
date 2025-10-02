using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine.Rendering.Universal;

namespace CommandBuses
{
    public class CommandBus
    {
        private readonly Dictionary<Type, ICommandHandler> handlers = new Dictionary<Type, ICommandHandler>();

        public void Register(Type commandType, ICommandHandler commandHandler)
        {
            this.handlers.Add(commandType, commandHandler);
        }

        public void Unregister(Type commandType)
        {
            this.handlers.Remove(commandType);
        }

        public async Task Execute<TCommand>(TCommand command) where TCommand : ICommand
        {
            Type commandType = command.GetType();
            if (this.handlers.TryGetValue(commandType, out ICommandHandler handler))
            {
                var commandHandler = handler as ICommandHandler<TCommand>;
                await commandHandler.Execute(command);
            }
        }
    }
}