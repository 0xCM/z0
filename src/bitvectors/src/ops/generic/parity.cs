//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static gmath;

    partial class BitVector
    {
        /// <summary>
        /// Computes the parity of a generic bitvector, which is 1 if an odd number of its components are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit parity<T>(BitVector<T> src)
            where T : unmanaged
                => odd(gbits.pop(src.State));

        /// <summary>
        /// Computes the parity of a natural bitvector, which is 1 if an odd number of its components are enabled and 0 otherwise
        /// </summary>
        /// <remarks>
        /// The parity function p:{0,1}x...x{0,1} -> {0,1} is a boolean function that attains the
        /// value 1 when an odd number of its input values are 1 and 0 otherwise.
        /// </remarks>
        [MethodImpl(Inline)]
        public static bit parity<N,T>(BitVector<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => math.odd(gbits.pop(src.State));

        /// <summary>
        /// Computes the parity of the source vector
        /// </summary>
        [MethodImpl(Inline)]
        public static bit parity<N,T>(in BitVector128<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => math.odd(BitVector.pop(src));

        /// <summary>
        /// Computes the Hamming distance between bitvectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static uint hamming<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => BitVector.pop(BitVector.xor(x,y));

    }
}