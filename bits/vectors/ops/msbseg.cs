//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;    

    partial class BitVector
    {
        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> msbseg<T>(BitVector<T> x, byte n)                
            where T : unmanaged
                => seg(x, x.Width - n, x.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline), Op]
        public static BitVector4 msbseg(BitVector4 x, byte n)                
            => seg(x, (byte)(x.Width - n), (byte)(x.Width - 1));                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline), Op]
        public static BitVector8 msbseg(BitVector8 x, byte n)                
            => seg(x, x.Width - n, x.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline), Op]
        public static BitVector16 msbseg(BitVector16 x, byte n)                
            => BitVector.seg(x.data, x.Width - n, x.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline), Op]
        public static BitVector32 msbseg(BitVector32 x, byte n)                
            => BitVector.seg(x.data, x.Width - n, x.Width - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n most significant bits of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="n">The count of most significant bits</param>
        [MethodImpl(Inline), Op]
        public static BitVector64 msbseg(BitVector64 x, byte n)                
            => BitVector.seg(x.data, x.Width - n, x.Width - 1);
    }
}