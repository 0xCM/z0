//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    


    [OpHost("bitvector.ops")]
    public static class BitVectorOps
    {
        /// <summary>
        /// Computes the bitwise TRUE operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> @true<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.@true<T>(x,y);

        /// <summary>
        /// Computes the bitwise FALSE operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> @false<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.@false<T>(x,y);

        /// <summary>
        /// Computes the bitwise AND of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> and<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.and(x,y);

        /// <summary>
        /// Computes the bitwise NAND of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> nand<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.nand(x,y);

        /// <summary>
        /// Computes the bitwise OR of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> or<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                =>  BitVector.or(x,y);

        /// <summary>
        /// Computes the bitwise NOR of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> nor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                =>  BitVector.nor(x,y);

        /// <summary>
        /// Computes the bitwise XOR of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> xor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                =>  BitVector.xor(x,y);

        /// <summary>
        /// Computes the bitwise Xnor of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> xnor<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.xnor(x,y);

        /// <summary>
        /// Defines the bitwise LeftProject operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> left<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.left(x,y);

        /// <summary>
        /// Defines the bitwise RightProject operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> right<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.right(x,y);

        /// <summary>
        /// Defines the bitwise LeftNot operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> lnot<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.lnot(x,y);

        /// <summary>
        /// Defines the bitwise RightNot operator
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> rnot<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.rnot(x,y);

        /// <summary>
        /// Computes the bitwise implication of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> impl<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.impl(x,y);

        /// <summary>
        /// Computes the bitwise nonimplication of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> nonimpl<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.nonimpl(x,y);

        /// <summary>
        /// Computes the bitwise converse implication of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> cimpl<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.cimpl(x,y);

        /// <summary>
        /// Computes the bitwise converse nonimplication of the source vectors via delegation to external bitvector API
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> cnonimpl<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => BitVector.cnonimpl(x,y);

        /// <summary>
        /// Computes the ternary select bitvector
        /// </summary>
        /// <param name="x">The adjudicator</param>
        /// <param name="y">The first branch</param>
        /// <param name="z">The second branch</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> select<T>(BitVector<T> x, BitVector<T> y, BitVector<T> z)
            where T : unmanaged
            => BitVector.select(x,y,z);
    }
}