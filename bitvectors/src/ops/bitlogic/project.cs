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
        /// Defines the bitwise LeftProject operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static BitVector<T> left<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => x;

        /// <summary>
        /// Defines the bitwise RightProject operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static BitVector<T> right<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => y;

        /// <summary>
        /// Defines the bitwise LeftNot operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static BitVector<T> lnot<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => ~x;

        /// <summary>
        /// Defines the bitwise RightNot operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static BitVector<T> rnot<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => ~y;



    }

}