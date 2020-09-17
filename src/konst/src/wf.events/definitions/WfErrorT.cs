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
    public readonly struct WfError<T> : IWfEvent<WfError<T>,T>, IWfError
    {
        public const string EventName = nameof(WfError<T>);

        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public WfStepId StepId {get;}

        public WfPayload<T> Data {get;}

        public FlairKind Flair {get;}

        public AppMsgSource Source {get;}

        [MethodImpl(Inline)]
        public WfError(string actor, T data, CorrelationToken ct, AppMsgSource source)
        {
            EventId = (EventName, ct);
            StepId = WfStepId.Empty;
            Actor = actor;
            Data = data;
            Flair =  FlairKind.Error;
            Source = source;
        }

        [MethodImpl(Inline)]
        public WfError(WfStepId step, T data, CorrelationToken ct, AppMsgSource source)
        {
            EventId = (EventName, step, ct);
            Actor = EmptyString;
            StepId = step;
            Data = data;
            Flair =  FlairKind.Error;
            Source = source;
        }

        [MethodImpl(Inline)]
        public WfError(WfStepId step, T data, string pattern, CorrelationToken ct, AppMsgSource source)
        {
            EventId = (EventName, step, ct);
            Actor = EmptyString;
            StepId = step;
            Data = data;
            Flair =  FlairKind.Error;
            Source = source;
        }


        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Source, Data);
    }
}