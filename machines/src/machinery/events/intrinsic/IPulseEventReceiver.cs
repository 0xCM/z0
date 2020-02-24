//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics.Tracing;
    using System.Collections.Generic;
    using static zfunc;

    public interface IPulseEventReceiver : IAgentEventSink<PulseEvent>
    {
        
    }

}