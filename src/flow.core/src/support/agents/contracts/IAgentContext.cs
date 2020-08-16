//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;


    public interface IAgentContext : IAppBase
    {
        IEnumerable<ISystemAgent> Memberhsip {get;}   

        IAgentEventSink EventLog {get;}        
    }
}