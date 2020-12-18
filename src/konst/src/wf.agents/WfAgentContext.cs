//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;


    public class WfAgentContext : IAgentContext
    {
        public IWfShell Wf {get;}

        readonly ConcurrentBag<IWfAgent> _Members;

        public WfAgentContext(IWfShell wf)
        {
            Wf = wf;
            _Members = new ConcurrentBag<IWfAgent>();
            EventLog = new WfEventSink(wf);
        }

        public IEnumerable<IWfAgent> Members
            => _Members;

        public IAgentEventSink EventLog {get;}

        public void Register(IWfAgent agent)
            => _Members.Add(agent);


        class WfEventSink : IAgentEventSink
        {
            IWfShell Wf;

            public WfEventSink(IWfShell wf)
            {
                Wf = wf;
            }

            public void AgentTransitioned(AgentTransition data)
            {

            }

            public void Receive(object data)
            {

            }
        }
    }
}