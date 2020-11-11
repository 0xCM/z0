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
    public readonly struct TraceEvent<T> : IWfEvent<TraceEvent<T>,T>
    {
        public const string EventName = GlobalEvents.Trace;

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public EventPayload<T> Payload {get;}

        public FlairKind Flair => FlairKind.Trace;

        [MethodImpl(Inline)]
        public TraceEvent(WfStepId step, T content, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            StepId = step;
            Payload = content;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Payload);
    }
}