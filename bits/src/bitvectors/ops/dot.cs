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
        /// Computes the scalar product between two generic bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static bit dot<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => parity(and(x,y));

        /// <summary>
        /// Computes the scalar product between two generic bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static bit dot<N,T>(BitVector<N,T> x, BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => parity(and(x,y));

        /// <summary>
        /// Computes the scalar product between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static bit dot(BitVector4 x, BitVector4 y)
            => parity(and(x, y));              

        /// <summary>
        /// Computes the scalar product between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static bit dot(BitVector8 x, BitVector8 y)
            => parity(and(x, y));              

        /// <summary>
        /// Computes the scalar product between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static bit dot(BitVector16 x, BitVector16 y)
            => parity(and(x, y));              

        /// <summary>
        /// Computes the scalar product between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static bit dot(BitVector32 x, BitVector32 y)
            => parity(and(x, y));              

        /// <summary>
        /// Computes the scalar product between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static bit dot(BitVector64 x, BitVector64 y)
            => parity(and(x, y));              

        /// <summary>
        /// Computes the scalar product between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline)]
        public static bit dot(in BitVector128 x, in BitVector128 y)
            => parity(and(x, y));              

    }
}