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
        public static WorkflowServer create(IAgentContext context, WorkflowServerConfig config)
            => new WorkflowServer(context, config);

        WorkflowServerConfig Config {get;}

        AgentProcess Worker {get; }

        internal WorkflowServer(IAgentContext context, WorkflowServerConfig config)
            : base(context, (config.ServerId, 0u))
        {
            Config = config;
            var pulse =  SourcedEvents.emitter(context,
                AgentIdentityPool.NextAgentId(PartId),
                new PulseEmitterConfig(new TimeSpan(0,0,1)));
            Worker = AgentProcess.create(context, PartId, config.CoreNumber, new IAgent[]{pulse});
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