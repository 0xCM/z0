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

        public FlairKind Flair => FlairKind.Ran;

        [MethodImpl(Inline)]
        public CmdSucceeded(CmdSpec cmd, T payload, CorrelationToken ct)
        {
            EventId = (EventName, cmd.CmdId, ct);
            Cmd = cmd;
            Payload = payload;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Cmd);
    }
}