//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IAgentContext : IWfContext
    {
        IEnumerable<IWfAgent> Members {get;}

        IAgentEventSink EventLog {get;}

        void Register(IWfAgent agent);
    }
}