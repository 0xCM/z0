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

        static Option<WfAgentComplex> Complex {get; set;}

        public static WfAgentComplex Define(AgentContext context)
            => new WfAgentComplex(context);

        /// <summary>
        /// Starts a new complex or returns the existing complex
        /// </summary>
        /// <param name="context">The context that the complex will inherit</param>
        /// <param name="servers"></param>
        public static async Task<WfAgentComplex> Start(AgentContext context)
        {
            if(Complex.IsSome())
                return Complex.ValueOrDefault();

            var servers = 20;
            var complex = WfAgentComplex.Define(context);
            var configs = new List<WfServerConfig>();
            var processors = Environment.ProcessorCount;
            term.inform($"Server complex using {processors} processor cores");

            for(uint i = 0, corenum = 1; i <= servers; i++, corenum++)
            {
                var sid = AgentIdentityPool.NextServerId();
                var config = new WfServerConfig(sid, $"Server{sid}", corenum);
                term.babble($"Defined configuration for {config}");
                configs.Add(config);
                if(corenum == processors)
                    corenum = 0;
            }

            var eventSink = TraceEventSink.Define(context, (complex.PartId, complex.HostId));
            complex.Configure(configs, eventSink);
            await complex.Start();
            Complex = complex;
            return complex;
        }

        static AgentIdentity Identity
            => (UInt32.MaxValue, UInt32.MaxValue);

        WfAgentComplex(AgentContext Context)
            : base(Context, Identity)
        {
            Servers = new WfServer[]{};
        }

        public void Configure(IEnumerable<WfServerConfig> config, IWfAgent sink)
        {
            var configs = config.ToArray();
            Servers = new WfServer[configs.Length];
            for(var i=0; i<configs.Length; i++)
                Servers[i] = WfServer.create(Context, configs[i]);

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