//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitVector
    {
        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the source vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline), LoSeg, Closures(Closure)]
        public static BitVector<T> loseg<T>(BitVector<T> src, byte n)
            where T : unmanaged
                => segment(src, 0, n -=1);

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="count">The count of least significant bits</param>
        [MethodImpl(Inline), LoSeg]
        public static BitVector4 loseg(BitVector4 x, byte count)
            => segment(x, 0, (byte)(count - 1));

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="count">The count of least significant bits</param>
        [MethodImpl(Inline), LoSeg]
        public static BitVector8 loseg(BitVector8 x, byte count)
            => segment(x,0, count -=1);

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="count">The count of least significant bits</param>
        [MethodImpl(Inline), LoSeg]
        public static BitVector16 loseg(BitVector16 src, byte count)
            => segment(src.Data,0,count -=1);

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="count">The count of least significant bits</param>
        [MethodImpl(Inline), LoSeg]
        public static BitVector32 loseg(BitVector32 src, byte count)
            => segment(src.Data,0,count -=1);

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline), LoSeg]
        public static BitVector64 loseg(BitVector64 src, byte n)
            => segment(src.Data,0, n -=1);

    }
}