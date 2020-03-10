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
    public class AgentContext : IAgentContext
    {
        public IAgentEventSink EventLog {get;}

        public AgentContext(IAgentEventSink EventLog)
        {
            this.EventLog = EventLog;
        }

        public void Register(ISystemAgent agent)
            => Agents.TryAdd(agent.Identity, agent);
                
        public IEnumerable<ISystemAgent> Memberhsip 
            => Agents.Values;        

        ConcurrentDictionary<ulong, ISystemAgent> Agents {get;}
            = new ConcurrentDictionary<ulong, ISystemAgent>();
    }

    /// <summary>
    /// Defines a shared context for a set of agents
    /// </summary>
    public class AgentContext<D> : IAgentContext<D>
    {

        public IAgentEventSink<D> EventLog {get;}
        
        public AgentContext InnerContext {get;}

        public AgentContext(IAgentEventSink<D> log)
        {
            this.EventLog = log;
            this.InnerContext = new AgentContext(log);
        }

        public void Register(ISystemAgent agent)
            => InnerContext.Register(agent);
                
        public IEnumerable<ISystemAgent> Memberhsip 
            => InnerContext.Memberhsip;
    }
}