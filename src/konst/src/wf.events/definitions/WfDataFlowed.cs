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
    public readonly struct WfDataFlowed<H,S,T,R> : IWfEvent<WfDataFlowed<H,S,T,R>>
        where H : IWfHost<H>, new()
    {
        public const string EventName = nameof(WfDataFlowed<H,S,T,R>);

        public WfEventId EventId {get;}
        public H Host {get;}

        public DataFlow<S,T,R> Flow {get;}
        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public WfDataFlowed(H host, DataFlow<S,T,R> flow, CorrelationToken ct, FlairKind flair = Ran)
        {
            Host = host;
            EventId = (EventName, Host.Id, ct);
            Flow = flow;
            Flair = flair;
        }

        public WfStepId StepId
             => Host.Id;

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Flow);
    }
}