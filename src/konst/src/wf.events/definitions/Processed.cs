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

    partial struct WfEvents
    {
        [Event]
        public readonly struct Processed<T> : IWfEvent<Processed<T>>
        {
            public const string EventName = nameof(Processed<T>);

            public WfEventId EventId {get;}

            public WfDataFlow<T> DataFlow {get;}

            public FlairKind Flair {get;}

            [MethodImpl (Inline)]
            public Processed(WfStepId step, WfDataFlow<T> flow, CorrelationToken ct, FlairKind flair = Ran)
            {
                EventId = (EventName, step, ct);
                DataFlow = flow;
                Flair = flair;
            }

            [MethodImpl (Inline)]
            public string Format()
                => Render.format(EventId, DataFlow);
        }

        [Event]
        public readonly struct Processed<S,T> : IWfEvent<Processed<S,T>>
        {
            public const string EventName = nameof(Processed<S,T>);

            public WfEventId EventId {get;}

            public WfDataFlow<S,T> DataFlow {get;}

            public FlairKind Flair {get;}

            [MethodImpl (Inline)]
            public Processed(WfStepId step, WfDataFlow<S,T> flow, CorrelationToken ct, FlairKind flair = Ran)
            {
                EventId = (EventName, step, ct);
                DataFlow = flow;
                Flair = flair;
            }

            [MethodImpl (Inline)]
            public string Format()
                => Render.format(EventId, DataFlow);
        }
    }
}