//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Symbolic;

    /// <summary>
    /// Defines a kinded token
    /// </summary>
    public readonly struct Token<S> : IToken<S>
        where S : unmanaged, ISymbol
    {
        /// <summary>
        readonly Index<S> Data;

        [MethodImpl(Inline)]
        public Token(S[] src)
            => Data = src;

        public ReadOnlySpan<S> Symbols
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public byte Length
        {
            [MethodImpl(Inline)]
            get => (byte)Data.Count;
        }

        public ref readonly S FirstSymbol
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public ref readonly S this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref Data[(byte)index];
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> Render()
            => api.render<S>(Data.Storage);

        [MethodImpl(Inline)]
        public string Format()
            => new string(Render());

        [MethodImpl(Inline)]
        public static implicit operator Token<S>(S[] src)
            => new Token<S>(src);
    }
}