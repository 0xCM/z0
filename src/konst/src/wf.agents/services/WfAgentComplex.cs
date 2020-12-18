//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Agent that manages a collection of servers
    /// </summary>
    public class WfAgentComplex : WfAgent
    {
        WfServer[] Servers;

        IWfAgent EventSink;

        internal static Option<WfAgentComplex> Complex {get; set;}

        static AgentIdentity Identity
            => (UInt32.MaxValue, UInt32.MaxValue);

        internal WfAgentComplex(AgentContext Context)
            : base(Context, Identity)
        {
            Servers = new WfServer[]{};
        }

        public void Configure(IEnumerable<WfServerConfig> config, IWfAgent sink)
        {
            var configs = config.ToArray();
            Servers = new WfServer[configs.Length];
            for(var i=0; i<configs.Length; i++)
                Servers[i] = WfAgents.server(Context, configs[i]);

            EventSink = sink;
        }

        protected override async void OnStart()
        {
            await EventSink.Start();
            Servers.Select(x => x.Start()).ToList();
        }

        protected override async void OnStop()
        {
            Servers.Select(x => x.Stop()).ToList();
            await EventSink?.Stop();
        }

        protected override void OnTerminate()
            => EventSink.Dispose();

        public override void Dispose()
        {
            Stop().Wait();
            Terminate().Wait();
        }
    }
}