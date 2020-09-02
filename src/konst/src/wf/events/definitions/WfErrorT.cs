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

    [Event]
    public readonly struct WfError<T> : IWfEvent<WfError<T>,T>, IWfError
    {
        public const string EventName = nameof(WfError<T>);

        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public WfStepId StepId {get;}

        public readonly T Data {get;}

        public WfPayload<T> Content => Data;

        public MessageFlair Flair {get;}

        public AppMsgSource Source {get;}

        [MethodImpl(Inline)]
        public WfError(string actor, T body, CorrelationToken ct, AppMsgSource source)
        {
            EventId = evid(EventName, ct);
            StepId = WfStepId.Empty;
            Actor = actor;
            Data = body;
            Flair =  MessageFlair.Red;
            Source = source;
        }

        [MethodImpl(Inline)]
        public WfError(WfStepId step, T body, CorrelationToken ct, AppMsgSource source)
        {
            EventId = evid(EventName, ct);
            Actor = EmptyString;
            StepId = step;
            Data = body;
            Flair =  MessageFlair.Red;
            Source = source;
        }

        public string Format()
            => format(EventId, Source, Content);
    }
}