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
    public readonly struct RunningCmdEvent : IWfEvent<RunningCmdEvent>
    {
        public const string EventName = GlobalEvents.RunningCmd;

        public const EventKind Kind = EventKind.RunningCmd;

        public WfEventId EventId {get;}

        public FlairKind Flair => FlairKind.Running;

        [MethodImpl(Inline)]
        public RunningCmdEvent(CmdId cmd, CorrelationToken ct)
        {
            EventId = (EventName, cmd, ct);
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}