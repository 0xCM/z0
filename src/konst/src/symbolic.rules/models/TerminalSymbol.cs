//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

   public readonly struct TerminalSymbol<S> : ITerminal<S>
        where S : unmanaged
    {
        public S Value {get;}

        [MethodImpl(Inline)]
        public TerminalSymbol(S value)
            => Value = value;

        [MethodImpl(Inline)]
        public static implicit operator TerminalSymbol<S>(S src)
            => new TerminalSymbol<S>(src);

        [MethodImpl(Inline)]
        public static implicit operator S(TerminalSymbol<S> src)
            => src.Value;
    }
}