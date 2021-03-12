//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = SymbolStores;

    /// <summary>
    /// Defines a kinded token
    /// </summary>
    public readonly struct Token<K,S>
        where K : unmanaged
        where S : unmanaged, ISymbol
    {
        /// <summary>
        /// Identifies the token within some scope
        /// </summary>
        public K Kind {get;}

        readonly Index<S> Data;

        [MethodImpl(Inline)]
        public Token(K kind, S[] src)
        {
            Kind = kind;
            Data = src;
        }

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
        public static implicit operator Token<K,S>(Paired<K,S[]> src)
            => new Token<K,S>(src.Left, src.Right);
    }
}