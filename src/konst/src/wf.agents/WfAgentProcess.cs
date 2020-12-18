//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Part;
    using static z;

    /// <summary>
    /// Responsible for managing agents owned by a server
    /// </summary>
    public class WfAgentProcess : WfAgent
    {

        internal WfAgentProcess(IAgentContext context, uint server, uint core, params IWfAgent[] agents)
            : base(context, (server, 1u))
        {
            Agents = agents.ToList();
            CoreNumber = (int)core;
        }

        readonly int CoreNumber;

        /// <summary>
        /// Exposes a readonly stream of the agents under management on behalf of the server
        /// </summary>
        public IEnumerable<IWfAgent> ServerAgents
            => Agents;

        List<IWfAgent> Agents {get;}
            = new List<IWfAgent>();

        protected override void OnStart()
        {
            thread(CurrentProcess.OsThreadId).OnSome(t => t.IdealProcessor = CoreNumber);
            foreach(var src in Agents)
                src.Start();
        }

        protected override void OnStop()
        {
            Agents.AsParallel().ForAll(a => a.Stop().Wait());
        }
    }
}