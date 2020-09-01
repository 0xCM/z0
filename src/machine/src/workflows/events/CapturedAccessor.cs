//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static z;

    [Event]
    public readonly struct CapturedAccessor : IWfEvent<CapturedAccessor>
    {
        public const string EventName = nameof(CapturedAccessor);

        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public readonly ApiHostUri Host;

        public readonly ResourceAccessor Accessor;

        public readonly AsmRoutineCode Code;

        [MethodImpl(Inline)]
        public CapturedAccessor(string actor, ApiHostUri host, in ResourceAccessor accessor, in AsmRoutineCode code, CorrelationToken ct)
        {
            EventId = evid(EventName, ct);
            Actor = actor;
            Host = host;
            Accessor = accessor;
            Code = code;
        }

        public string Format()
            => format(EventId, Actor);
    }
}