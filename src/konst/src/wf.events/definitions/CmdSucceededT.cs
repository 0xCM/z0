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
    public readonly struct CmdSucceeded<T> : IWfEvent<CmdSucceeded<T>>
    {
        public const string EventName = nameof(GlobalEvents.CmdExec);

        public WfEventId EventId {get;}

        public CmdSpec Cmd {get;}

        public EventPayload<T> Payload {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public CmdSucceeded(CmdSpec cmd, T payload, CorrelationToken ct, FlairKind flair = FlairKind.Ran)
        {
            EventId = (EventName, cmd.CmdId, ct);
            Cmd = cmd;
            Payload = payload;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Cmd);
    }
}