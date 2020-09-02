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

    public readonly struct WfStepCreated<T> : IWfEvent<WfStepCreated<T>,T>
    {
        public const string EventName = nameof(WfStepCreated);

        public WfStepId StepId {get;}

        public WfEventId EventId {get;}

        public WfPayload<T> Content {get;}

        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public WfStepCreated(WfStepId step, T content, CorrelationToken ct, MessageFlair flair = Created)
        {
            EventId = (EventName, step, ct);
            StepId = step;
            Content = content;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Content);
    }
}