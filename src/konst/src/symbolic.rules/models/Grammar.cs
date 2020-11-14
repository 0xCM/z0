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

    public readonly struct Grammars
    {

    }

    public readonly struct Production<N,T>
    {

    }

    /// <summary>
    /// Represents a basic generative grammar over a finite set of nonterminal <typeparamref name='S'/> symbols
    /// and a necessarily disjoint set of terminal <typeparamref name='T'/> symbols
    /// </summary>
    public readonly struct Grammar<S,T>
        where S : unmanaged, INonterminal<S>
        where T : unmanaged, ITerminal<T>
    {
        public IndexedView<S> Symbols {get;}

        public IndexedView<T> Terminals {get;}
    }
}