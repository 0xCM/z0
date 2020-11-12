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
    public class WorkflowServer : WorkflowAgent
    {
        public static WorkflowServer create(IAgentContext context, ServerConfig config)
            => new WorkflowServer(context, config);

        ServerConfig Config {get;}

        AgentProcess Worker {get; }

        internal WorkflowServer(IAgentContext Context, ServerConfig Config)
            : base(Context, (Config.ServerId, 0u))
        {
            this.Config = Config;
            var hearbeat = PulseEmitter.create(Context,
                ServiceIdentityPool.NextAgentId(PartId),
                new PulseEmitterConfig(new TimeSpan(0,0,1)));
            this.Worker = AgentProcess.create(Context, PartId, Config.CoreNumber, new IWfAgent[]{hearbeat});
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