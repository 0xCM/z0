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
    using static AB;
    using static z;

    [Event]
    public readonly struct WfStatus<T> : IWfEvent<WfStatus<T>, T>
    {
        public static Type EventType = typeof(WfStatus<T>);
        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public WfPayload<T> Content {get;}

        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public WfStatus(WfStepId step, T content, CorrelationToken ct, MessageFlair flair = Status)
        {
            EventId = (EventType, step, ct);
            StepId = step;
            Flair =  flair;
            Content = content;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Content);
    }
}