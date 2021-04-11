namespace Z0
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;

    class Controller : BackgroundService
    {
        readonly ILogger<Controller> Logger;

        readonly IEnvPaths Paths;

        readonly IArchiveMonitor Monitor;

        public Controller(ILogger<Controller> logger)
        {
            Logger = logger;
            Paths = EnvPaths.create();
            Monitor = ArchiveMonitor.start(Paths.DbRoot(), OnChange);
        }

        void OnChange(FileChange change)
        {
            Logger.LogInformation(change.Format());
        }

        public override void Dispose()
        {
            base.Dispose();
            Monitor?.Dispose();
        }

        protected override async Task ExecuteAsync(CancellationToken cancel)
        {
            while (!cancel.IsCancellationRequested)
            {
                //Logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, cancel);
            }
        }
    }
}
