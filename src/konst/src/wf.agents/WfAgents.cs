//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;

    using static z;

    [ApiHost]
    public readonly struct WfAgents
    {
        public static IWfAgentControl control(IWfContext context)
            => new WfAgentControl(context);

        /// <summary>
        /// Creates and configures, but does not start, a server process
        /// </summary>
        /// <param name="Context">The context to which the server process will be assigned</param>
        /// <param name="ServerId">The server id</param>
        /// <param name="ServerAgents">The agents to be managed on behalf of the server</param>
        public static WfAgentProcess process(IAgentContext Context, uint ServerId, uint CoreNumber, params IWfAgent[] ServerAgents)
            => new WfAgentProcess(Context, ServerId, CoreNumber, ServerAgents);

        public static WfServer server(IAgentContext context, WfServerConfig config)
            => new WfServer(context, config);

        /// <summary>
        /// Starts a new complex or returns the existing complex
        /// </summary>
        /// <param name="context">The context that the complex will inherit</param>
        /// <param name="servers"></param>
        public static async Task<WfAgentComplex> complex(AgentContext context)
        {
            if(WfAgentComplex.Complex.IsSome())
                return WfAgentComplex.Complex.ValueOrDefault();

            var servers = 20;
            var complex = new WfAgentComplex(context);
            var configs = list<WfServerConfig>();
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
            WfAgentComplex.Complex = complex;
            return complex;
        }

    }
}