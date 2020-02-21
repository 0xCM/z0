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

    /// <summary>
    /// Defines a shared context for a set of agents
    /// </summary>
    public class AgentContext : Context, IAgentContext
    {
        ConcurrentDictionary<ulong, ISystemAgent> Agents {get;}
            = new ConcurrentDictionary<ulong, ISystemAgent>();

        public AgentContext(IPolyrand random, IAgentEventSink EventLog)
            : base(random)
        {
            this.EventLog = EventLog;
        }

        public IAgentEventSink EventLog {get;}

        public void Register(ISystemAgent agent)
        {
            Agents.TryAdd(agent.Identity, agent);
        }
        
        IEnumerable<ISystemAgent> IAgentContext.Memberhsip 
            => Agents.Values;        
    }
}