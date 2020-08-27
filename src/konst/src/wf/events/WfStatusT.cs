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
    using static RenderPatterns;
    using static z;

    [Event]
    public readonly struct WfStatus<T> : IWfEvent<WfStatus<T>, T>
    {
        public const string EventName = nameof(WfStatus<T>);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public T Content {get;}

        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public WfStatus(string actor, T body, CorrelationToken ct, MessageFlair flair = Status)
        {
            EventId = evid(EventName, ct);
            StepId = WfStepId.Empty;
            Flair =  flair;
            Content = body;
        }

        [MethodImpl(Inline)]
        public WfStatus(WfStepId step, T body, CorrelationToken ct, MessageFlair flair = Status)
        {
            EventId = evid(EventName, ct);
            StepId = step;
            Flair =  flair;
            Content = body;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, StepId, Content);
    }
}