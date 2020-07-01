//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Konst;
    using static Root;

    /// <summary>
    /// Responsible for managing agents owned by a server
    /// </summary>
    public class ServerProcess : SystemAgent
    {    
        /// <summary>
        /// Creates and configures, but does not start, a server process
        /// </summary>
        /// <param name="Context">The context to which the server process will be assigned</param>
        /// <param name="ServerId">The server id</param>
        /// <param name="ServerAgents">The agents to be managed on behalf of the server</param>
        public static ServerProcess Define(AgentContext Context, uint ServerId, uint CoreNumber, params ISystemAgent[] ServerAgents)
            => new ServerProcess(Context, ServerId, CoreNumber, ServerAgents);

        internal ServerProcess(AgentContext content, uint server, uint core, params ISystemAgent[] agents)
            : base(content, (server, 1u))
        {
            Agents = agents.ToList();
            CoreNumber = (int)core;
        }

        readonly int CoreNumber;

        /// <summary>
        /// Exposes a readonly stream of the agents under management on behalf of the server
        /// </summary>
        public IEnumerable<ISystemAgent> ServerAgents
            => Agents;

        List<ISystemAgent> Agents {get;}
            = new List<ISystemAgent>();
        
        protected override void OnStart()
        {            
            thread(CurrentProcess.CurrentThreadId).OnSome(t => t.IdealProcessor = CoreNumber);
            foreach(var src in Agents)
                src.Start();
        }

        protected override void OnStop()
        {
            Agents.AsParallel().ForAll(a => a.Stop().Wait());
        }
    }
}