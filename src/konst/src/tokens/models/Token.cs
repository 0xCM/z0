//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using api = Symbolic;

    /// <summary>
    /// Represents a lexical token
    /// </summary>
    public readonly struct Token<K,S> : IToken<K,S>
        where K : unmanaged
        where S : unmanaged, ISymbol
    {
        /// <summary>
        /// Identifies the token within some scope
        /// </summary>
        public K Id {get;}

        readonly TableSpan<S> Data;

        [MethodImpl(Inline)]
        public Token(K id, S[] src)
        {
            Id = id;
            Data = src;
        }

        public ReadOnlySpan<S> Symbols
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public uint4 Length
        {
            [MethodImpl(Inline)]
            get => (byte)Data.Count;
        }

        public ref readonly S FirstSymbol
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public ref readonly S this[uint4 index]
        {
            [MethodImpl(Inline)]
            get => ref Data[(byte)index];
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> Render()
            => api.render<S>(Data.Storage);

        [MethodImpl(Inline)]
        public string Format()
            => z.format(Render());

        [MethodImpl(Inline)]
        public static implicit operator Token<K,S>(Paired<K,S[]> src)
            => new Token<K,S>(src.Left, src.Right);
    }
}