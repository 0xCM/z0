//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [Event(EventName)]
    public readonly struct CmdSucceeded : IWfEvent<CmdSucceeded>
    {
        public const string EventName = nameof(GlobalEvents.CmdExec);

        public WfEventId EventId {get;}

        public CmdSpec Cmd {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public CmdSucceeded(CmdSpec cmd, CorrelationToken ct, FlairKind flair = FlairKind.Ran)
        {
            EventId = (EventName, cmd.Id, ct);
            Cmd = cmd;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId);
    }
}