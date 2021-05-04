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
    public readonly struct ToolRanEvent : IWfEvent<ToolRanEvent>
    {
        public const string EventName = GlobalEvents.ToolRan;

        public const EventKind Kind = EventKind.ToolRan;

        public EventId EventId {get;}

        public ToolExecSpec Cmd {get;}

        public bool Ok {get;}

        public FlairKind Flair => Ok ? FlairKind.Ran : FlairKind.Error;

        [MethodImpl(Inline)]
        public ToolRanEvent(ToolExecSpec cmd, bool ok, CorrelationToken ct)
        {
            EventId = (EventName, cmd.CmdId, ct);
            Ok = ok;
            Cmd = cmd;
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}