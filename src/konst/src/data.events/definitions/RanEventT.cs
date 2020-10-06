//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static z;

    [Event]
    public readonly struct RanEvent<T> : IWfEvent<RanEvent<T>, T>
    {
        public const string EventName = nameof(GlobalEvents.Ran);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public EventPayload<T> Payload {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public RanEvent(WfStepId step, T data, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            StepId = step;
            Payload = data;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Payload);
    }
}