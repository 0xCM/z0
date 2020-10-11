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

    [Event(EventName)]
    public readonly struct StatusEvent<C,R> : IWfEvent<StatusEvent<C,R>, R>
        where C : IWfStep<C>, new()
        where R : ITextual
    {
        public const string EventName = nameof(GlobalEvents.Status);

        public WfEventId EventId {get;}

        public WfFunc<C,R> Func {get;}

        public EventPayload<R> Payload {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public StatusEvent(WfFunc<C,R> f, R content, CorrelationToken ct, FlairKind flair = Status)
        {
            EventId = (f, ct);
            Func = f;
            Flair =  flair;
            Payload = content;
        }

        public WfStepId StepId
            => Func.StepId;

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Payload);
    }
}