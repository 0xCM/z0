//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct PrimalFsmSpecs
    {
        public static PrimalSpec<S,E,R> create<S,E,R>(S[] states, E[] events, R[] results)
            where S : unmanaged
            where E : unmanaged
            where R : unmanaged
                => new PrimalSpec<S,E,R>(states,events,results);
    }
    
    public readonly struct PrimalSpec<S,E,R>
        where S : unmanaged
        where E : unmanaged
        where R : unmanaged
    {
        public readonly TableSpan<S> States;

        public readonly TableSpan<E> Events;

        public readonly TableSpan<R> Results;
        
        [MethodImpl(Inline)]
        public PrimalSpec(S[] states, E[] events, R[] results)
        {
            States = states;
            Events = events;
            Results = results;
        }        
    }
}