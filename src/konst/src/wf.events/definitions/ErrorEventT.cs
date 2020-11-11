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

        public AppMsgSource Source {get;}

        public EventPayload<T> Payload {get;}

        public FlairKind Flair => FlairKind.Error;

        public string Summary => Exception ? Exception.Value.Message : Payload.Format();

        public string Detail => Exception ? Exception.Value.ToString() : Payload.Format();

        [MethodImpl(Inline)]
        public ErrorEvent(CmdId cmd, T data, CorrelationToken ct, AppMsgSource source)
        {
            EventId = (EventName, cmd, ct);
            Exception = none<Exception>();
            Payload = data;
            Source = source;
        }

        [MethodImpl(Inline)]
        public ErrorEvent(Exception error, T data, CorrelationToken ct, AppMsgSource source)
        {
            EventId = (EventName, ct);
            Exception = error;
            Payload = data;
            Source = source;
        }

        [MethodImpl(Inline)]
        public ErrorEvent(WfStepId step, T data, CorrelationToken ct, AppMsgSource source)
        {
            EventId = (EventName, step, ct);
            Exception = none<Exception>();
            Payload = data;
            Source = source;
        }

        public string Format()
            => string.Format(RP.PSx3, EventId, Source, Detail);

        public string FormatSummary()
            => string.Format(RP.PSx3, EventId, Source, Summary);
    }
}