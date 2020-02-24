//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static zfunc;

    public interface IAgentContext : IRngContext
    {
        IEnumerable<ISystemAgent> Memberhsip {get;}   

        IAgentEventSink EventLog {get;}        
    }
}