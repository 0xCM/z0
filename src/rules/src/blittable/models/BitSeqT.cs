//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    /// <summary>
    /// Defines a contiguous seqence of bits
    /// </summary>
    public struct BitSeq<T> : IBitSeq<T>
        where T : unmanaged
    {
        T _Storage;


        [MethodImpl(Inline)]
        public BitSeq(T data)
        {
            _Storage = data;
        }

        public T Storage
        {
            [MethodImpl(Inline)]
            get => _Storage;
        }

        public Span<byte> Edit
        {
            [MethodImpl(Inline)]
            get => bytes(_Storage);
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => bytes(_Storage);
        }
    }
}