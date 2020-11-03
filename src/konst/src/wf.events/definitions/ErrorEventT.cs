//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [Event(EventName)]
    public readonly struct ErrorEvent<T> : IWfEvent<ErrorEvent<T>,T>, IWfErrorEvent
    {
        public const string EventName = GlobalEvents.Error;

        public WfEventId EventId {get;}

        public Option<Exception> Exception {get;}

        public WfStepId StepId {get;}

        public EventPayload<T> Data {get;}

        public FlairKind Flair {get;}

        public AppMsgSource Source {get;}

        public string Summary => Exception ? Exception.Value.Message : Data.Format();

        public string Detail => Exception ? Exception.Value.ToString() : Data.Format();

        [MethodImpl(Inline)]
        public ErrorEvent(CmdId cmd, T data, CorrelationToken ct, AppMsgSource source)
        {
            EventId = (EventName, cmd, ct);
            StepId = WfStepId.Empty;
            Exception = none<Exception>();
            Data = data;
            Flair =  FlairKind.Error;
            Source = source;
        }

        [MethodImpl(Inline)]
        public ErrorEvent(Exception error, T data, CorrelationToken ct, AppMsgSource source)
        {
            EventId = (EventName, ct);
            StepId = WfStepId.Empty;
            Exception = error;
            Data = data;
            Flair =  FlairKind.Error;
            Source = source;
        }

        [MethodImpl(Inline)]
        public ErrorEvent(WfStepId step, T data, CorrelationToken ct, AppMsgSource source)
        {
            EventId = (EventName, step, ct);
            Exception = none<Exception>();
            StepId = step;
            Data = data;
            Flair =  FlairKind.Error;
            Source = source;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.PSx3, EventId, Source, Detail);

        public string FormatSummary()
            => string.Format(RP.PSx3, EventId, Source, Summary);

    }
}