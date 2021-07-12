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
        public T State {get;}

        [MethodImpl(Inline)]
        public BitVector32(T src)
            => State = src;

        uint Untyped
        {
            [MethodImpl(Inline)]
            get => @as<T,uint>(State);
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(State);
        }

        [MethodImpl(Inline)]
        public bool Equals(BitVector32<T> other)
            => Untyped == other.Untyped;

        public string Format(BitFormat config)
            => BitRender.formatter<T>(config).Format(State);
        public string Format()
            => BitRender.formatter<T>().Format(State);
    }
}