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
    public readonly struct CmdRanEvent : IWfEvent<CmdRanEvent>
    {
        public const string EventName = GlobalEvents.CmdRan;

        public WfEventId EventId {get;}

        public CmdSpec Cmd {get;}

        public bool Ok {get;}

        public FlairKind Flair => Ok ? FlairKind.Ran : FlairKind.Error;

        [MethodImpl(Inline)]
        public CmdRanEvent(CmdSpec cmd, bool ok, CorrelationToken ct)
        {
            EventId = (EventName, cmd.CmdId, ct);
            Ok = ok;
            Cmd = cmd;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(EventId);
    }
}