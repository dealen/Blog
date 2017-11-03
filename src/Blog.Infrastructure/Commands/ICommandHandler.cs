using System.Threading.Tasks;

namespace Blog.Infrastructure.Commands
{
    public interface ICommandHandler<T> where T : ICommand
    {
         Task HandleAsync(T command);
    }
}