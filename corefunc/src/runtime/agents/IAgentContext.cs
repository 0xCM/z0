//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static zfunc;

    public interface IAgentContext : IContext
    {
        IEnumerable<ISystemAgent> Memberhsip {get;}   

        IAgentEventSink EventLog {get;}        
    }

    public interface IAgentContext<D> : IAgentContext
    {
        new IAgentEventSink<D> EventLog {get;}

        IAgentEventSink IAgentContext.EventLog
            => EventLog;
    }
}