//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IAgentContext : IShellContext
    {
        IEnumerable<ISystemAgent> Members {get;}

        IAgentEventSink EventLog {get;}
    }
}