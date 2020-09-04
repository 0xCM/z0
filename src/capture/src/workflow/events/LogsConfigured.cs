//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LogsConfigured : IWfEvent<LogsConfigured>
    {
        public const string EventName = nameof(LogsConfigured);

        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public WfLogConfig Config {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public LogsConfigured(string actor, WfLogConfig config, CorrelationToken ct, FlairKind flair = FlairKinds.Ran)
        {
            EventId = WfEventId.define(EventName, ct);
            Actor = actor;
            Config = config;
            Flair = flair;
        }

        public string Format()
            => Render.format(EventId, Actor, Config);
    }
}