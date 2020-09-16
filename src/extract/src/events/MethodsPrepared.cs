//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Events
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static z;

    public readonly struct MethodsPrepared : IWfEvent<MethodsPrepared>
    {
        public const string EventName = nameof(MethodsPrepared);

        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public ApiHostUri Host {get;}

        public Count Count {get;}

        [MethodImpl(Inline)]
        public MethodsPrepared(WfActor actor, ApiHostUri host, int count, CorrelationToken ct)
        {
            EventId = evid(EventName, ct);
            Actor = actor;
            Host = host;
            Count = count;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Actor, Host, Count);
    }
}