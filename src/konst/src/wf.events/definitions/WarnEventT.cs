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
    public readonly struct WarnEvent<T> : IWfEvent<WarnEvent<T>,T>
    {
        public const string EventName = GlobalEvents.Warning;

        public const EventKind Kind = EventKind.Warn;

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public EventPayload<T> Payload {get;}

        public FlairKind Flair => FlairKind.Warning;

        [MethodImpl(Inline)]
        public WarnEvent(WfStepId step, T content, CorrelationToken ct)
        {
            EventId = WfEventId.define(EventName, step);
            Payload = content;
            StepId = step;
        }

        public string Format()
            => TextFormatter.format(EventId, StepId, Payload);
    }
}