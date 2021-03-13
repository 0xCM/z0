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

    public readonly struct TokenList<I,K> : IIndex<I,Token<K>>
        where K : unmanaged
        where I : unmanaged
    {
        readonly Index<I,Token<K>> Data;

        [MethodImpl(Inline)]
        public TokenList(Token<K>[] src)
            => Data = src;

        public ref Token<K> this[I index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ReadOnlySpan<Token<K>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<Token<K>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => bw32(Data.Count);
        }

        public ref Token<K> First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public Token<K>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator TokenList<I,K>(Token<K>[] src)
            => new TokenList<I,K>(src);

        [MethodImpl(Inline)]
        public static implicit operator Token<K>[](TokenList<I,K> src)
            => src.Storage;
    }
}