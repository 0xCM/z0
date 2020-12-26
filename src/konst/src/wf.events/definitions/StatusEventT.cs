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
    public readonly struct StatusEvent<T> : IWfEvent<StatusEvent<T>,T>
    {
        public const string EventName = GlobalEvents.Status;

        public WfEventId EventId {get;}

        public EventPayload<T> Payload {get;}

        public FlairKind Flair => FlairKind.Status;

        [MethodImpl(Inline)]
        public StatusEvent(WfStepId step, T data, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            Payload = data;
        }

        [MethodImpl(Inline)]
        public StatusEvent(WfStepId step, string label, T data, CorrelationToken ct)
        {
            EventId = (EventName, label, step, ct);
            Payload = data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(EventId, Payload);
    }
}