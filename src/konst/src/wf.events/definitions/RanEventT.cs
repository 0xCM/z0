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
    public readonly struct RanEvent<T> : IWfEvent<RanEvent<T>,T>
    {
        public const string EventName = GlobalEvents.Ran;

        public static EventLevel Level => FlairKind.Status;

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public EventPayload<T> Payload {get;}

        public FlairKind Flair => FlairKind.Ran;

        [MethodImpl(Inline)]
        public RanEvent(WfStepId step, T data, CorrelationToken ct)
        {
            EventId = (EventName, step, Level, ct);
            StepId = step;
            Payload = data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(EventId, Payload);
    }
}