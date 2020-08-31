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

    public readonly struct WfStepRunning<T> : IWfEvent<WfStepRunning<T>>
    {
        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public WfPayload<T> Content {get;}

        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public WfStepRunning(WfStepId step, T body, CorrelationToken ct, MessageFlair flair = Running)
        {
            EventId = id(step, ct);
            StepId = step;
            Content = body;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Content);
    }
}