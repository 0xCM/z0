//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Event(Kind)]
    public readonly struct TraceEvent<T> : IWfEvent<TraceEvent<T>,T>
    {
        public const string EventName = GlobalEvents.Trace;

        public const EventKind Kind = EventKind.Trace;

        public EventId EventId {get;}

        public WfStepId StepId {get;}

        public EventPayload<T> Payload {get;}

        public FlairKind Flair => FlairKind.Trace;

        [MethodImpl(Inline)]
        public TraceEvent(WfStepId step, T content, CorrelationToken ct)
        {
            EventId = EventId.define(EventName, step);
            StepId = step;
            Payload = content;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(EventId, Payload);
    }
}