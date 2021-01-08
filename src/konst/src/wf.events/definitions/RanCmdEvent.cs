//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Part;

    [Event(Kind)]
    public readonly struct RanCmdEvent : IWfEvent<RanCmdEvent>
    {
        public const string EventName = GlobalEvents.RanCmd;

        public const EventKind Kind = EventKind.CmdRan;

        public WfEventId EventId {get;}

        public FlairKind Flair => FlairKind.Ran;

        [MethodImpl(Inline)]
        public RanCmdEvent(CmdResult cmd, CorrelationToken ct)
        {
            EventId = (EventName, cmd.CmdId, ct);
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}