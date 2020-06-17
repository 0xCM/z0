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
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline), HiSeg, Closures(UnsignedInts)]
        public static BitVector<T> hiseg<T>(BitVector<T> x, byte n)                
            where T : unmanaged
                => bitseg(x, (byte)(x.Width - n), (byte)(x.Width - 1));                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline), HiSeg]
        public static BitVector4 hiseg(BitVector4 x, byte n)                
            => bitseg(x, (byte)(x.Width - n), (byte)(x.Width - 1));                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline), HiSeg]
        public static BitVector8 hiseg(BitVector8 x, byte n)                
            => bitseg(x, (byte)(x.Width - n), (byte)(x.Width - 1));                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline), HiSeg]
        public static BitVector16 hiseg(BitVector16 x, byte n)                
            => bitseg(x, (byte)(x.Width - n), (byte)(x.Width - 1));                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline), HiSeg]
        public static BitVector32 hiseg(BitVector32 x, byte n)                
            => BitVector.bitseg(x.Data, (byte)(x.Width - n), (byte)(x.Width - 1));                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline), HiSeg]
        public static BitVector64 hiseg(BitVector64 x, byte n)                
            => bitseg(x, (byte)(x.Width - n), (byte)(x.Width - 1));                

    }
}