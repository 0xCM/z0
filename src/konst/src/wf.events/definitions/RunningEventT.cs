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
    public readonly struct RunningEvent<T> : IWfEvent<RunningEvent<T>,T>
    {
        public const string EventName = GlobalEvents.Running;

        public const EventKind Kind = EventKind.Running;

        public static EventLevel Level => FlairKind.Status;

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public EventPayload<T> Payload {get;}

        public Name Operation {get;}

        public FlairKind Flair => FlairKind.Running;

        [MethodImpl(Inline)]
        public RunningEvent(WfStepId step, T data, CorrelationToken ct = default)
        {
            EventId = WfEventId.define(EventName, step);
            StepId = step;
            Payload = data;
        }

        [MethodImpl(Inline)]
        public RunningEvent(WfStepId step, string operation, T data, CorrelationToken ct = default)
        {
            EventId = WfEventId.define(EventName, step);
            Operation = operation;
            StepId = step;
            Payload = data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Operation.IsEmpty ? TextFormatter.format(EventId, Payload) : TextFormatter.format(EventId, Operation, Payload);
    }
}