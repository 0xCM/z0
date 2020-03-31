//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;    

    partial class BitVector
    {
        /// <summary>
        /// Computes z := x << s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The shift amount</param>
        [MethodImpl(Inline)]
        public static BitVector<T> sll<T>(BitVector<T> x, byte s)
            where T : unmanaged
                => gmath.sll(x.Scalar,s);

        /// <summary>
        /// Computes z := x << s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift s</param>
        [MethodImpl(Inline)]
        public static BitVector4 sll(BitVector4 x, byte s)
            => math.sll(x.Scalar,s);

        /// <summary>
        /// Computes z := x << s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift s</param>
        [MethodImpl(Inline)]
        public static BitVector8 sll(BitVector8 x, byte s)
            => math.sll(x.Scalar,s);
            
        /// <summary>
        /// Computes z := x << s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift s</param>
        [MethodImpl(Inline)]
        public static BitVector16 sll(BitVector16 x, byte s)
            => math.sll(x.Scalar,s);

        /// <summary>
        /// Computes z := x << s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift s</param>
        [MethodImpl(Inline)]
        public static BitVector32 sll(BitVector32 x, byte s)
            => math.sll(x.Scalar,s);

        /// <summary>
        /// Computes z := x << s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift s</param>
        [MethodImpl(Inline)]
        public static BitVector64 sll(BitVector64 x, byte s)
            => math.sll(x.Scalar,s);
 
   }
}