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

    public readonly struct RunningEvent<T> : IWfEvent<RunningEvent<T>, T>
    {
        public const string EventName = nameof(RunningEvent<T>);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public WfPayload<T> Payload {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public RunningEvent(WfStepId step, T data, CorrelationToken ct, FlairKind flair = Running)
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