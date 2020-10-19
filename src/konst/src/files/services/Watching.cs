//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct Watching<T> : IWfEvent<Watching<T>>
        where T : ITextual
    {
        public const string EventName = nameof(Watching<T>);
                
        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public T Target {get;}

        [MethodImpl(Inline)]
        public Watching(string actor, T subject, CorrelationToken ct)
        {
            EventId = WfEventId.define(EventName, ct);
            Actor = actor;
            Target = subject;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Actor, Target);
    }
}