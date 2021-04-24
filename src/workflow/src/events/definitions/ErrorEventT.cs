//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Event(Kind)]
    public readonly struct ErrorEvent<T> : IWfEvent<ErrorEvent<T>,T>, IErrorEvent
    {
        public const string EventName = GlobalEvents.Error;

        public const EventKind Kind = EventKind.Error;

        public WfEventId EventId {get;}

        public Option<Exception> Exception {get;}

        public EventOrigin Source {get;}

        public EventPayload<T> Payload {get;}

        public FlairKind Flair => FlairKind.Error;

        public string Summary {get;}

        [MethodImpl(Inline)]
        public ErrorEvent(CmdId cmd, T data, EventOrigin source)
        {
            EventId = (Kind, cmd, CorrelationToken.Default);
            Exception = root.none<Exception>();
            Payload = data;
            Source = source;
            Summary = Payload.Format();
        }

        [MethodImpl(Inline)]
        public ErrorEvent(Exception error, T data, EventOrigin source)
        {
            EventId = (EventName, CorrelationToken.Default);
            Exception = error;
            Payload = data;
            Source = source;
            Summary = Exception ? Exception.Value.ToString() : Payload.Format();
        }

        [MethodImpl(Inline)]
        public ErrorEvent(string label, T data,  EventOrigin source)
        {
            EventId = (EventName, label, CorrelationToken.Default);
            Exception = root.none<Exception>();
            Payload = data;
            Source = source;
            Summary = Payload.Format();
        }

        [MethodImpl(Inline)]
        public ErrorEvent(WfStepId step, T data, EventOrigin source)
        {
            EventId = (EventName, step, CorrelationToken.Default);
            Exception = root.none<Exception>();
            Payload = data;
            Source = source;
            Summary = Payload.Format();
        }

        public string Format()
            => text.format(RP.PSx3, EventId, Source, Summary);
    }
}