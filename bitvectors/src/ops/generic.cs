//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    

    partial class BitVector
    {
        /// <summary>
        /// Creates a generic bitvector
        /// </summary>
        /// <param name="src">The source cell</param>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static BitVector<T> generic<T>(T src)
            where T : unmanaged
                => new BitVector<T>(src);

        /// <summary>
        /// Creates a generic bitvector from a span of bytes
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="n">The bitvector length</param>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static BitVector<T> generic<T>(Span<byte> src)
            where T : unmanaged
                => generic(src.TakeScalar<T>());

        /// <summary>
        /// Loads an bitvector of minimal size from a source bitstring
        /// </summary>
        /// <param name="src">The bitstring source</param>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static BitVector<T> generic<T>(BitString src)
            where T : unmanaged
                => generic<T>(src.ToPackedBytes());

        /// <summary>
        /// Creates a byte-generic bitvector
        /// </summary>
        [MethodImpl(Inline), Op]
        public static BitVector<byte> generic(N8 n8, byte a)
            => a;

        /// <summary>
        /// Creates a byte-generic bitvector from 4 bits
        /// </summary>
        [MethodImpl(Inline), Op]
        public static BitVector<byte> generic(N8 n, bit b0, bit b1, bit b2, bit b3)
            => create(n, b0, b1, b2, b3);

        /// <summary>
        /// Creates a byte-generic bitvector from 4 explicit bytes
        /// </summary>
        /// <param name="src">The source bitstring</param>
        [MethodImpl(Inline), Op]
        public static BitVector<uint> generic(byte x0, byte x1, byte x2, byte x3)
            => generic(Bits.concat(x0,x1,x2,x3));
    }
}