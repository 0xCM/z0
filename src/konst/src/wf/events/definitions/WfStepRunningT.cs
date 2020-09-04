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

    public readonly struct WfStepRunning<T> : IWfEvent<WfStepRunning<T>, T>
    {
        public const string EventName = nameof(WfStepRunning<T>);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public WfPayload<T> Content {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public WfStepRunning(WfStepId step, T data, CorrelationToken ct, FlairKind flair = Running)
        {
            EventId = (EventName, step, ct);
            StepId = step;
            Content = data;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Content);
    }
}