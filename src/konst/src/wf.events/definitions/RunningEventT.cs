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
    public readonly struct RunningEvent<T> : IWfEvent<RunningEvent<T>,T>
    {
        public const string EventName = GlobalEvents.Running;

        public static EventLevel Level => FlairKind.Status;

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public EventPayload<T> Payload {get;}

        public FlairKind Flair => FlairKind.Running;

        [MethodImpl(Inline)]
        public RunningEvent(WfStepId step, T data, CorrelationToken ct)
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