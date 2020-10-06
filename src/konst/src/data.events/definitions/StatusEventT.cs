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
    using static WfCore;
    using static z;

    [Event]
    public readonly struct StatusEvent<T> : IWfStatus<T>
    {
        public const string EventName = nameof(GlobalEvents.Status);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public EventPayload<T> Content {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public StatusEvent(WfStepId step, T content, CorrelationToken ct, FlairKind flair = Status)
        {
            EventId = (EventName, step, ct);
            StepId = step;
            Flair =  flair;
            Content = content;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Content);
    }
}