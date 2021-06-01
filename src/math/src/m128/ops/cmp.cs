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
        /// Determines whether the left and right operands define the same value
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        [MethodImpl(Inline), Eq]
        public static bit eq(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => x.Left == y.Left && x.Right == y.Right;

        /// <summary>
        /// Determines whether the left operand is less than the right operand
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Lt]
        public static bit lt(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => x.Right < y.Right | ((x.Right == y.Right) && (x.Left < y.Left));

         /// <summary>
        /// Determines whether the left operand is less than or equal the right operand
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), LtEq]
        public static bit lteq(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => x.Right < y.Right | ((x.Right == y.Right) && (x.Left <= y.Left));

        /// <summary>
        /// Determines whether the left operand is greater than the right operand
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Gt]
        public static bit gt(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => !lteq(x,y);

        /// <summary>
        /// Determines whether the left operand is greater than or equal the right operand
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), GtEq]
        public static bit gteq(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => !lt(x,y);
    }
}