using System.Threading.Tasks;

namespace CommandBuses
{
    public interface ICommandHandler
    {
    }

    public interface ICommandHandler<TCommand> : ICommandHandler where TCommand : ICommand
    {
        Task Execute(TCommand command);
    }
}