//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    

    partial class BitVector
    {
        /// <summary>
        /// Computes the scalar product between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static bit dot<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => parity(and(x,y));

        /// <summary>
        /// Computes the scalar product between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static bit dot(BitVector4 x, BitVector4 y)
            => parity(and(x, y));              

        /// <summary>
        /// Computes the scalar product between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static bit dot(BitVector8 x, BitVector8 y)
            => parity(and(x, y));              

        /// <summary>
        /// Computes the scalar product between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static bit dot(BitVector16 x, BitVector16 y)
            => parity(and(x, y));              

        /// <summary>
        /// Computes the scalar product between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static bit dot(BitVector32 x, BitVector32 y)
            => parity(and(x, y));              

        /// <summary>
        /// Computes the scalar product between two bitvectors
        /// </summary>
        /// <param name="x">The left bitvector</param>
        /// <param name="y">The right bitvector</param>
        [MethodImpl(Inline), Op]
        public static bit dot(BitVector64 x, BitVector64 y)
            => parity(and(x, y));              

   }
}