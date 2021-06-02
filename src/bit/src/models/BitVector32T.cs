//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    /// <summary>
    /// Defines a 32-bit bitvector
    /// </summary>
    public struct BitVector32<T> : IBitVector<BitVector32<T>, T>
        where T : unmanaged
    {
        public T Content {get;}

        [MethodImpl(Inline)]
        public BitVector32(T src)
            => Content = src;

        uint Untyped
        {
            [MethodImpl(Inline)]
            get => @as<T,uint>(Content);
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(Content);
        }

        [MethodImpl(Inline)]
        public bool Equals(BitVector32<T> other)
            => Untyped == other.Untyped;

        public string Format(BitFormat config)
            => BitRender.formatter<T>(config).Format(Content);
        public string Format()
            => BitRender.formatter<T>().Format(Content);
    }
}