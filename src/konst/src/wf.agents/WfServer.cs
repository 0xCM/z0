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
    public class WfServer : WfAgent
    {
        WfServerConfig Config {get;}

        WfAgentProcess Worker {get; }

        internal WfServer(IAgentContext context, WfServerConfig config)
            : base(context, (config.ServerId, 0u))
        {
            Config = config;
            var pulse =  SourcedEvents.emitter(context,
                AgentIdentityPool.NextAgentId(PartId),
                new PulseEmitterConfig(new TimeSpan(0,0,1)));
            Worker = WfAgents.process(context, PartId, config.CoreNumber, new IWfAgent[]{pulse});
        }

        protected override async void OnStart()
            => await Worker.Start();

        protected override async void OnStop()
            => await Worker.Stop();
    }
}