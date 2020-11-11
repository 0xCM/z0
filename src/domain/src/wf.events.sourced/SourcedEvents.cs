//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SourcedEvents
    {
        [MethodImpl(Inline), Op]
        public static PulseEvent pulse(uint server, uint agent, ulong ts)
            => new PulseEvent(new AgentEventId(server, agent, ts, IntrinsicEvents.Pulse));
    }
}