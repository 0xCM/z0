//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class BitVector
    {
        /// <summary>
        /// Computes z := x << s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The shift amount</param>
        [MethodImpl(Inline), Sll, Closures(Closure)]
        public static BitVector<T> sll<T>(BitVector<T> x, byte offset)
            where T : unmanaged
                => gmath.sll(x.Data,offset);

        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The shift amount</param>
        [MethodImpl(Inline)]
        public static BitVector<N,T> sll<N,T>(BitVector<N,T> x, byte offset)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.sll(x.Data,offset);

        /// <summary>
        /// Computes z := x >> s for a bitvector x and shift offset s
        /// </summary>
        /// <param name="x">The source bitvector</param>
        /// <param name="offset">The shift amount</param>
        [MethodImpl(Inline)]
        public static BitVector128<N,T> sll<N,T>(in BitVector128<N,T> x, byte offset)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => gcpu.vsllx(x.Data,offset);
    }
}