using System.Collections.Generic;
using System.Threading.Tasks;
using CommandBuses;

namespace DailyLogins
{
    public class RemoteConfigHandler<TCommand> : ICommandHandler<TCommand> where TCommand : ICommand
    {
        public RemoteConfigHandler(List<CommandOption<TCommand>> options)
        {
        }

        public async Task Execute(TCommand command)
        {
            await Task.CompletedTask;
        }
    }

    public class CommandOption<TCommand> where TCommand : ICommand
    {
        public string OptionValue { get; set; }
        public ICommandHandler<TCommand> Handler { get; set; }
    }
}