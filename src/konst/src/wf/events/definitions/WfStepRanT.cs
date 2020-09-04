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
    using static z;

    [Event]
    public readonly struct WfStepRan<T> : IWfEvent<WfStepRan<T>, T>
    {
        public const string EventName = nameof(WfStepRan<T>);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public WfPayload<T> Content {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public WfStepRan(WfStepId step, T data, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            StepId = step;
            Content = data;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Content);
    }
}