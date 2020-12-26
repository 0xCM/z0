//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
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

        public string Summary {get;}

        [MethodImpl(Inline)]
        public ErrorEvent(CmdId cmd, T data, CorrelationToken ct, AppMsgSource source)
        {
            EventId = (EventName, cmd, ct);
            Exception = none<Exception>();
            Payload = data;
            Source = source;
            Summary = Payload.Format();
        }

        [MethodImpl(Inline)]
        public ErrorEvent(Exception error, T data, CorrelationToken ct, AppMsgSource source)
        {
            EventId = (EventName, ct);
            Exception = error;
            Payload = data;
            Source = source;
            Summary = Exception ? Exception.Value.Message : Payload.Format();
        }

        [MethodImpl(Inline)]
        public ErrorEvent(string label, T data, CorrelationToken ct, AppMsgSource source)
        {
            EventId = (EventName, label, ct);
            Exception = none<Exception>();
            Payload = data;
            Source = source;
            Summary = Payload.Format();
        }

        [MethodImpl(Inline)]
        public ErrorEvent(WfStepId step, T data, CorrelationToken ct, AppMsgSource source)
        {
            EventId = (EventName, step, ct);
            Exception = none<Exception>();
            Payload = data;
            Source = source;
            Summary = Payload.Format();
        }

        public string Format()
            => string.Format(RP.PSx3, EventId, Source, Summary);
    }
}