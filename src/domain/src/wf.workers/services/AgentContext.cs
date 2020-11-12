//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a shared context for a set of agents
    /// </summary>
    public class AgentContext : IAgentContext
    {
        public IAgentEventSink EventLog {get;}

        [MethodImpl(Inline)]
        public AgentContext(IAgentEventSink sink)
        {
            EventLog = sink;
        }

        public void Register(IWfAgent agent)
            => Agents.TryAdd(agent.Identity, agent);

        public IEnumerable<IWfAgent> Members
            => Agents.Values;

        ConcurrentDictionary<ulong,IWfAgent> Agents {get;}
            = new ConcurrentDictionary<ulong, IWfAgent>();
    }
}