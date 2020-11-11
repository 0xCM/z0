//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines a logical server
    /// </summary>
    public class ServerAgent : SystemAgent
    {
        public static ServerAgent create(IAgentContext context, ServerConfig config)
            => new ServerAgent(context, config);

        ServerConfig Config {get;}

        ServerProcess Worker {get; }

        internal ServerAgent(IAgentContext Context, ServerConfig Config)
            : base(Context, (Config.ServerId, 0u))
        {
            this.Config = Config;
            var hearbeat = PulseEmitter.create(Context,
                ServiceIdentityPool.NextAgentId(ServerId),
                new PulseEmitterConfig(new TimeSpan(0,0,1)));
            this.Worker = ServerProcess.create(Context, ServerId, Config.CoreNumber, new IWorkflowAgent[]{hearbeat});
        }

        protected override async void OnStart()
        {
            await Worker.Start();
        }

        protected override async void OnStop()
        {
            await Worker.Stop();
        }
    }
}