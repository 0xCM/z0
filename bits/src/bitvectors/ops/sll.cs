//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static nfunc;
    using static As;

    partial class BitVector
    {
        /// <summary>
        /// Computes z := x << s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The shift amount</param>
        [MethodImpl(Inline)]
        public static BitVector<T> sll<T>(BitVector<T> x, int s)
            where T : unmanaged
                => gmath.sll(x.Scalar,s);

        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The shift amount</param>
        [MethodImpl(Inline)]
        public static BitVector<T> sll<N,T>(BitVector<N,T> x, int s)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.sll(x.Scalar,s);

        /// <summary>
        /// Computes z := x << s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift s</param>
        [MethodImpl(Inline)]
        public static BitVector4 sll(BitVector4 x, int s)
            => math.sll(x.Scalar,s);

        /// <summary>
        /// Computes z := x << s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift s</param>
        [MethodImpl(Inline)]
        public static BitVector8 sll(BitVector8 x, int s)
            => math.sll(x.Scalar,s);
            
        /// <summary>
        /// Computes z := x << s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift s</param>
        [MethodImpl(Inline)]
        public static BitVector16 sll(BitVector16 x, int s)
            => math.sll(x.Scalar,s);

        /// <summary>
        /// Computes z := x << s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift s</param>
        [MethodImpl(Inline)]
        public static BitVector32 sll(BitVector32 x, int s)
            => math.sll(x.Scalar,s);

        /// <summary>
        /// Computes z := x << s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="y">The shift s</param>
        [MethodImpl(Inline)]
        public static BitVector64 sll(BitVector64 x, int s)
            => math.sll(x.Scalar,s);
 
        /// <summary>
        /// Computes z := x << s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="s">The shift amount</param>
        [MethodImpl(Inline)]
        public static BitVector128 sll(BitVector128 x, int s)
        {
            var z = BitVector.alloc(n128);
            vblock.sllx(n128, in x.x0, (byte)s, ref z.x0);
            return z;
        }


    }

}