//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static z;

    [Event(EventName)]
    public readonly struct RunningCmdEvent : IWfEvent<RunningCmdEvent>
    {
        public const string EventName = nameof(GlobalEvents.RunningCmd);

        public WfEventId EventId {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public RunningCmdEvent(CmdId cmd, CorrelationToken ct, FlairKind flair = Running)
        {
            EventId = (EventName, cmd, ct);
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}