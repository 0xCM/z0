//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Event(EventName)]
    public readonly struct RanEvent : IWfEvent<RanEvent>
    {
        public const string EventName = GlobalEvents.Ran;

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public FlairKind Flair => FlairKind.Ran;

        [MethodImpl(Inline)]
        public RanEvent(WfStepId step, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            StepId = step;
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}