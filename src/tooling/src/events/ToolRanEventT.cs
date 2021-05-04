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
    public readonly struct ToolRanEvent<T> : IWfEvent<ToolRanEvent<T>>
    {
        public const string EventName = GlobalEvents.ToolRan;

        public const EventKind Kind = EventKind.ToolRan;

        public EventId EventId {get;}

        public ToolExecSpec Cmd {get;}

        public EventPayload<T> Payload {get;}

        public bool Ok {get;}

        public FlairKind Flair => Ok ? FlairKind.Ran : FlairKind.Error;

        [MethodImpl(Inline)]
        public ToolRanEvent(ToolExecSpec cmd, bool ok, T data, CorrelationToken ct)
        {
            EventId = (EventName, cmd.CmdId, ct);
            Ok = ok;
            Cmd = cmd;
            Payload = data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(EventId, Cmd);
    }
}