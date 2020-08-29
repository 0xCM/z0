//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct PrimalFsmSpec<S,E,R>
        where S : unmanaged
        where E : unmanaged
        where R : unmanaged
    {
        public readonly TableSpan<S> States;

        public readonly TableSpan<E> Events;

        public readonly TableSpan<R> Results;
        
        public readonly TableSpan<TransitionRule<E,S>> Rules;
        
        [MethodImpl(Inline)]
        public PrimalFsmSpec(S[] states, E[] events, R[] results, params TransitionRule<E,S>[] rules)
        {
            States = states;
            Events = events;
            Results = results;
            Rules = rules;
        }        
    }
}