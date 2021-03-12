//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct Tokens<I,K,S> : IIndex<I,Token<K,S>>
        where K : unmanaged
        where S : unmanaged, ISymbol
        where I : unmanaged
    {
        readonly Index<Token<K,S>> Data;

        [MethodImpl(Inline)]
        public Tokens(Token<K,S>[] src)
            => Data = src;

        public ref Token<K,S> this[I index]
        {
            [MethodImpl(Inline)]
            get => ref Data[@as<I,uint>(index)];
        }

        public ReadOnlySpan<Token<K,S>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<Token<K,S>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ushort Count
        {
            [MethodImpl(Inline)]
            get => (ushort)Data.Count;
        }

        public ref Token<K,S> First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public Token<K,S>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator Tokens<I,K,S>(Token<K,S>[] src)
            => new Tokens<I,K,S>(src);

        [MethodImpl(Inline)]
        public static implicit operator Token<K,S>[](Tokens<I,K,S> src)
            => src.Storage;
    }
}