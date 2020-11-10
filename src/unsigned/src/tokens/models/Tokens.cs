//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Tokens<K,S>
        where K : unmanaged
        where S : unmanaged, ISymbol
    {
        readonly TableSpan<Token<K,S>> Data;

        [MethodImpl(Inline)]
        public Tokens(Token<K,S>[] src)
            => Data = src;

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

        [MethodImpl(Inline)]
        public static implicit operator Tokens<K,S>(Token<K,S>[] src)
            => new Tokens<K,S>(src);
    }
}