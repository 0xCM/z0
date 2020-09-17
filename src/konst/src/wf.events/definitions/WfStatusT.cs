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
    using static Flow;
    using static z;

    [Event]
    public readonly struct WfStatus<T> : IWfStatus<T>
    {
        public static string EventName = nameof(WfStatus<T>);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public WfPayload<T> Content {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public WfStatus(WfStepId step, T content, CorrelationToken ct, FlairKind flair = Status)
        {
            EventId = (EventName, step, ct);
            StepId = step;
            Flair =  flair;
            Content = content;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Content);
    }
}