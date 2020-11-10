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

    public readonly struct Grammar<N,T>
        where N : unmanaged, INonterminal<N>
        where T : unmanaged, ITerminal<T>

    {

    }

    public interface INonterminal<S> : ISymbol<S>
        where S : unmanaged
    {

    }

    public interface ITerminal<S> : ISymbol<S>
        where S : unmanaged
    {

    }

    public readonly struct TerminalSymbol<S> : ITerminal<S>
        where S : unmanaged
    {
        public S Value { get; }

        [MethodImpl(Inline)]
        public TerminalSymbol(S value)
            => Value = value;
    }


    public readonly struct Nonterminal<S> : INonterminal<S>
        where S : unmanaged
    {
        public S Value { get; }

        [MethodImpl(Inline)]
        public Nonterminal(S value)
            => Value = value;
    }
}