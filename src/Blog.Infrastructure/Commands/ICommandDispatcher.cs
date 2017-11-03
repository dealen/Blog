using System.Threading.Tasks;

namespace Blog.Infrastructure.Commands
{
    public interface ICommandDispatcher
    {
         Task DispatchAsync<T>(T Command) where T : ICommand;
    }
}