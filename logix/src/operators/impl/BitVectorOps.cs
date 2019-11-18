//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    public static class BitVectorOps
    {
        /// <summary>
        /// Computes the bitwise TRUE operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> @true<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.ones<T>();

        /// <summary>
        /// Computes the bitwise FALSE operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> @false<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.zero<T>();

        /// <summary>
        /// Computes the bitwise AND of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> and<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => x & y;

        /// <summary>
        /// Computes the bitwise NAND of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> nand<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.nand(x,y);

        /// <summary>
        /// Computes the bitwise OR of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> or<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => x | y;

        /// <summary>
        /// Computes the bitwise NOR of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> nor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => ~ (x | y);

        /// <summary>
        /// Computes the bitwise XOR of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> xor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => x ^ y;

        /// <summary>
        /// Computes the bitwise Xnor of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> xnor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => ~(x ^ y);

        /// <summary>
        /// Defines the bitwise LeftProject operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> left<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => x;

        /// <summary>
        /// Defines the bitwise RightProject operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> right<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => y;

        /// <summary>
        /// Defines the bitwise LeftNot operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> lnot<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => ~x;

        /// <summary>
        /// Defines the bitwise RightNot operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> rnot<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => ~y;

        /// <summary>
        /// Computes the bitwise implication of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> imply<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => x | ~y;

        /// <summary>
        /// Computes the bitwise nonimplication of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> notimply<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.nonimpl(x,y);

        /// <summary>
        /// Computes the bitwise converse implication of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> cimply<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => ~x | y;

        /// <summary>
        /// Computes the bitwise converse nonimplication of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal scalar upon which the bitvector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> cnotimply<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.cnonimpl(x,y);

        /// <summary>
        /// Computes the ternary select bitvector
        /// </summary>
        /// <param name="x">The adjudicator</param>
        /// <param name="y">The first branch</param>
        /// <param name="z">The second branch</param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> select<T>(BitVector<T> x, BitVector<T> y, BitVector<T> z)
            where T : unmanaged
            => BitVector.select(x,y,z);
    }
}