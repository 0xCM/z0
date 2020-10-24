//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    using static Konst;
    using static z;

    partial class WfShell
    {
        long RunningToken;

        long RanToken;

        ConcurrentDictionary<ulong,ExecutionFlow> Flows {get;}
            = new ConcurrentDictionary<ulong,ExecutionFlow>();

        public ExecutionFlow Running()
        {
            if(Wf.Verbosity.Babble())
                Wf.Raise(WfEvents.running(Host, Ct));

            var running = ExecutionFlow.create((ulong)atomic(ref RunningToken));
            return running;
        }

        public void Ran()
        {
            if(Wf.Verbosity.Babble())
                Wf.Raise(new RanEvent(Host, Ct));
        }

        public void Ran(ExecutionFlow flow)
        {
            if(Wf.Verbosity.Babble())
                Wf.Raise(new RanEvent(Host, Ct));

            var ran = flow.Reacted((ulong)atomic(ref RanToken));
            Flows.TryAdd(flow.Dispensed, flow);
        }
    }
}