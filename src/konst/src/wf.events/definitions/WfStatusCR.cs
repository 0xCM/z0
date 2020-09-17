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
    public readonly struct WfStatus<C,R> : IWfEvent<WfStatus<C,R>, R>
        where C : struct, IWfStep<C>
        where R : ITextual
    {
        public const string EventName = nameof(WfStatus<C,R>);

        public WfEventId EventId {get;}

        public WfFunc<C,R> Func {get;}

        public WfPayload<R> Content {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public WfStatus(WfFunc<C,R> f, R content, CorrelationToken ct, FlairKind flair = Status)
        {
            EventId = (f, ct);
            Func = f;
            Flair =  flair;
            Content = content;
        }

        public WfStepId StepId
            => Func.StepId;

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Content);
    }
}