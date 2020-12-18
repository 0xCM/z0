//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Event(EventName)]
    public readonly struct CmdSucceededEvent : IWfEvent<CmdSucceededEvent>
    {
        public const string EventName = GlobalEvents.CmdExec;

        public WfEventId EventId {get;}

        public CmdSpec Cmd {get;}

        public FlairKind Flair  => FlairKind.Ran;

        [MethodImpl(Inline)]
        public CmdSucceededEvent(CmdSpec cmd, CorrelationToken ct)
        {
            EventId = (EventName, cmd.CmdId, ct);
            Cmd = cmd;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(EventId);
    }
}