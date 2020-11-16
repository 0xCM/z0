//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public class WfAgentContext : IAgentContext
    {
        public IWfShell Wf {get;}

        public WfAgentContext(IWfShell wf)
        {
            Wf = wf;
            Members = sys.empty<IWfAgent>();
            EventLog = new WfEventSink(wf);
        }

        public IEnumerable<IWfAgent> Members {get;}

        public IAgentEventSink EventLog {get;}

        public void Register(IWfAgent agent)
        {

        }

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