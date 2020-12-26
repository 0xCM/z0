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
    public readonly struct CmdRanEvent<T> : IWfEvent<CmdRanEvent<T>>
    {
        public const string EventName = GlobalEvents.CmdRan;

        public const EventKind Kind = EventKind.CmdRan;

        public WfEventId EventId {get;}

        public CmdSpec Cmd {get;}

        public EventPayload<T> Payload {get;}

        public bool Ok {get;}

        public FlairKind Flair => Ok ? FlairKind.Ran : FlairKind.Error;

        [MethodImpl(Inline)]
        public CmdRanEvent(CmdSpec cmd, bool ok, T data, CorrelationToken ct)
        {
            EventId = (EventName, cmd.CmdId, ct);
            Ok = ok;
            Cmd = cmd;
            Payload = data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(EventId, Cmd);
    }
}