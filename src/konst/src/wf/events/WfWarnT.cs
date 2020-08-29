//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RenderPatterns;
    using static z;

    [Event]
    public readonly struct WfWarn<T> : IWfEvent<WfWarn<T>,T>
    {
        public const string EventName = nameof(WfWarn<T>);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public T Content {get;}

        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public WfWarn(WfStepId step, T body, CorrelationToken ct)
        {
            EventId = evid(EventName, ct);
            Content = body;
            StepId = step;
            Flair = MessageFlair.Yellow;
        }
        public string Format()
            => text.format(PSx3, EventId, StepId, Content);
    }
}