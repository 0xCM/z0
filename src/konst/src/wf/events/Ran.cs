//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static z;

    [Event(EventName)]
    public readonly struct RanEvent : IWfEvent<RanEvent>
    {
        public const string EventName = nameof(GlobalEvents.Ran);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public RanEvent(WfStepId step, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            StepId = step;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}