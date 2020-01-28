//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    partial class BitVector
    {
        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the source vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> lsbseg<T>(BitVector<T> x, byte n)                
            where T : unmanaged
                => seg(x, 0, n - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline), Op]
        public static BitVector4 lsbseg(BitVector4 x, byte n)                
            => seg(x, 0, (byte)(n - 1));                

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline), Op]
        public static BitVector8 lsbseg(BitVector8 x, byte n)                
            => seg(x,0, n - 1);                

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline), Op]
        public static BitVector16 lsbseg(BitVector16 x, byte n)                
            => seg(x.data,0,n-1);

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline), Op]
        public static BitVector32 lsbseg(BitVector32 x, byte n)                
            => seg(x.data,0,n-1);

        /// <summary>
        /// Constructs a bitvector formed from the n lest significant bits of the current vector
        /// </summary>
        /// <param name="n">The count of least significant bits</param>
        [MethodImpl(Inline), Op]
        public static BitVector64 lsbseg(BitVector64 x, byte n)                
            => seg(x.data,0, n-1);
    }
}