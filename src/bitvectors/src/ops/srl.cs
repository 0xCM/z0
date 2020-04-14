//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    partial class BitVector
    {
        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The shift amount</param>
        [MethodImpl(Inline), Srl]
        public static BitVector4 srl(BitVector4 x, byte offset)
            => gmath.srl(x.data,offset);

        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The shift amount</param>
        [MethodImpl(Inline), Srl]
        public static BitVector8 srl(BitVector8 x, byte offset)
            => gmath.srl(x.data,offset);
            
        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The shift amount</param>
        [MethodImpl(Inline), Srl]
        public static BitVector16 srl(BitVector16 x, byte offset)
            => gmath.srl(x.data,offset);

        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The shift amount</param>
        [MethodImpl(Inline), Srl]
        public static BitVector32 srl(BitVector32 x, byte offset)
            => gmath.srl(x.data, offset);

        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The shift amount</param>
        [MethodImpl(Inline), Srl]
        public static BitVector64 srl(BitVector64 x, byte offset)
            => gmath.srl(x.data,offset);            

        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The shift amount</param>
        [MethodImpl(Inline), Srl, Closures(UnsignedInts)]
        public static BitVector<T> srl<T>(BitVector<T> x, byte offset)
            where T : unmanaged
                => gmath.srl(x.Scalar,offset);

        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The shift amount</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> srl<N,T>(BitVector<N,T> x, byte offset)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.srl(x.Scalar,offset);

        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The shift amount</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> srl<N,T>(in BitVector128<N,T> x, byte offset)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => gvec.vsrlx(x.data,offset); 

   }
}