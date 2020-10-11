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
        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public CpuCycledEvent(WfStepId step, CpuCycleInfo  info, CorrelationToken ct, FlairKind flair = FlairKind.Status)
        {
            EventId = (EventName, step, ct);
            Description = info;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Description);
    }
}