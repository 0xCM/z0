//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static RenderPatterns;
    using static z;

    public readonly struct WfStepRunning<T> : IWfEvent<WfStepRunning<T>>
    {
        public const string EventName = nameof(WfStepRunning<T>);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public T Body {get;}

        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public WfStepRunning(WfStepId step, T body, CorrelationToken ct, MessageFlair flair = Running)
        {
            EventId = evid(EventName, ct);
            StepId = step;
            Body = body;
            Flair = flair;
        }


        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, StepId, Body);
    }
}