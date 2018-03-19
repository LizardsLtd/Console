namespace Lizards.Console
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IAsyncRunnable
    {
        Task Run(CancellationToken token);
    }
}