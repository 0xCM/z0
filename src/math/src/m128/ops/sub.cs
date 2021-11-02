//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Math128
    {
        /// <summary>
        /// Subtraction mod 2^128.
        /// </summary>
        /// <remarks>Adapted from IntUtils.cs / Microsoft Machine Learning repository</remarks>
        [MethodImpl(Inline), Sub]
        public static void sub(ref Pair<ulong> dst, ulong src)
        {
            if (dst.Left < src)
                dst.Right--;
            dst.Left -= src;
        }

        /// <summary>
        /// Subtraction mod 2^128.
        /// </summary>
        /// <remarks>Adapted from IntUtils.cs / Microsoft Machine Learning repository</remarks>
        [MethodImpl(Inline), Sub]
        public static void sub(in Pair<ulong> src, ref Pair<ulong> dst)
        {
            dst.Right -= src.Right;
            if (dst.Left < src.Left)
                dst.Right--;
            dst.Left -= src.Left;
        }

        /// <summary>
        /// Computes the difference c := a - b between 128-bit unsigned integers a and b
        /// </summary>
        /// <param name="a">A reference to the left 128-bits</param>
        /// <param name="b">A reference to the right 128-bits</param>
        /// <param name="c">A reference to the target 128-bits</param>
        /// <remarks>Adapted from https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Sub]
        public static void sub(in ulong a, in ulong b, ref ulong c)
        {
            c = a - b;
            var borrow = a < c;
            seek(c, 1) = skip(in a, 1) - skip(in b, 1) - uint32(borrow);
        }

        /// <summary>
        /// Computes the difference of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Adapted from https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Sub]
        public static ConstPair<ulong> sub(in ConstPair<ulong> x, in ConstPair<ulong> y)
        {
            var lo = x.Left - y.Left;
            var borrow = x.Left < lo;
            var hi = x.Right - y.Right - uint32(borrow);
            return (lo, hi);
        }
    }
}