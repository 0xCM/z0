//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static core;

    partial class math
    {
        [MethodImpl(Inline), Add]
        public static sbyte add(sbyte a, sbyte b)
            => (sbyte)(a + b);

        [MethodImpl(Inline), Add]
        public static byte add(byte a, byte b)
            => (byte)(a + b);

        [MethodImpl(Inline), Add]
        public static short add(short a, short b)
            => (short)(a + b);

        [MethodImpl(Inline), Add]
        public static ushort add(ushort a, ushort b)
            => (ushort)(a + b);

        [MethodImpl(Inline), Add]
        public static int add(int a, int b)
            => a + b;

        [MethodImpl(Inline), Add]
        public static uint add(uint a, uint b)
            => a + b;

        [MethodImpl(Inline), Add]
        public static long add(long a, long b)
            => a + b;

        [MethodImpl(Inline), Add]
        public static ulong add(ulong a, ulong b)
            => a + b;

        /// <summary>
        /// Computes the sum of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> add(in ConstPair<ulong> x, in ConstPair<ulong> y)
        {
            var lo = x.Left + y.Left;
            var carry = x.Left > lo;
            var hi = x.Right + y.Right + core.@uint(carry);
            return (lo,hi);
        }

        /// <summary>
        /// Computes the sum c := a + b of 128-bit unsigned integers a and b
        /// </summary>
        /// <param name="a">A reference to the left 128-bits</param>
        /// <param name="b">A reference to the right 128-bits</param>
        /// <param name="c">A reference to the target 128-bits</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static void add(in ulong a, in ulong b, ref ulong c)
        {
            c = a + b;
            var carry = a > c;
            seek(c, 1) = skip(in a, 1) + skip(in b, 1) + core.@uint(carry);
        }
    }
}