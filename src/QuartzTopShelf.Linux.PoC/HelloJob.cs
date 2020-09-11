using Quartz;
using Serilog;
using System.Threading.Tasks;

namespace QuartzTopShelf.Linux.Service
{
    public class HelloJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            var lastRun = context.PreviousFireTimeUtc?.DateTime.ToString() ?? string.Empty;
            Log.Warning("Greetings from HelloJob!   Previous run: {lastRun}", lastRun);
            return Task.CompletedTask;
        }
    }
}