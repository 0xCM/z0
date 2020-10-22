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
    public readonly struct RanCmdEvent : IWfEvent<RanCmdEvent>
    {
        public const string EventName = nameof(GlobalEvents.RanCmd);

        public WfEventId EventId {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public RanCmdEvent(CmdResult cmd, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, cmd.CmdId, ct);
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}