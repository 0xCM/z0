//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Math128
    {
        /// <summary>
        /// Computes the bitwise OR of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Or]
        public static ConstPair<ulong> or(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => Tuples.@const(x.Left | y.Left, x.Right | y.Right);

        /// <summary>
        /// Computes the bitwise complement of a 128-bit integer
        /// </summary>
        /// <param name="x">The integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Not]
        public static ConstPair<ulong> not(in ConstPair<ulong> x)
            => Tuples.@const(~x.Left, ~x.Right);

        /// <summary>
        /// Computes the bitwise XOR of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Xor]
        public static ConstPair<ulong> xor(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => Tuples.@const(x.Left ^ y.Left, x.Right ^ y.Right);

        [MethodImpl(Inline), Nor]
        public static ConstPair<ulong> nor(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => not(or(x,y));

        /// <summary>
        /// Computes the bitwise AND of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), And]
        public static ConstPair<ulong> and(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => Tuples.@const(x.Left & y.Left, x.Right & y.Right);

        /// <summary>
        /// Computes the bitwise NAND of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Nand]
        public static ConstPair<ulong> nand(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => not(and(x,y));

        /// <summary>
        /// Computes the bitwise XNOR of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Xnor]
        public static ConstPair<ulong> xnor(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => not(xor(x,y));
    }
}