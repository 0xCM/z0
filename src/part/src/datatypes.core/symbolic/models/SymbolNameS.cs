//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines the name of a symbol
    /// </summary>
    public readonly struct SymbolName<S>
        where S : unmanaged
    {
        readonly IToken<S> Token;

        [MethodImpl(Inline)]
        internal SymbolName(IToken<S> src)
            => Token = src;

        public Identifier Identifier
        {
            [MethodImpl(Inline)]
            get => Token.Identifier;
        }

        public TextBlock SymbolText
        {
            [MethodImpl(Inline)]
            get => Token.SymbolText;
        }

        [MethodImpl(Inline)]
        public string Format()
            => SymbolText;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator SymbolName<S>(Token<S> src)
            => new SymbolName<S>(src);

        [MethodImpl(Inline)]
        public static implicit operator SymbolName(SymbolName<S> src)
            => new SymbolName(src.Token);
    }
}