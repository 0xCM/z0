//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Event(EventName)]
    public readonly struct CpuCycledEvent<T> : IWfEvent<CpuCycledEvent<T>>
    {
        public const string EventName = "CpuCycled";

        public WfEventId EventId {get;}

        public CpuCycleInfo Description {get;}

        public FlairKind Flair => FlairKind.Status;

        [MethodImpl(Inline)]
        public CpuCycledEvent(WfStepId step, CpuCycleInfo info, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            Description = info;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Description);
    }
}