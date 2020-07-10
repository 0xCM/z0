//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;

    partial class math
    {
        [MethodImpl(Inline), Sub]
        public static sbyte sub(sbyte a, sbyte b)
            => (sbyte)(a - b);

        [MethodImpl(Inline), Sub]
        public static byte sub(byte a, byte b)
            => (byte)(a - b);

        [MethodImpl(Inline), Sub]
        public static short sub(short a, short b)
            => (short)(a - b);

        [MethodImpl(Inline), Sub]
        public static ushort sub(ushort a, ushort b)
            => (ushort)(a - b);

        [MethodImpl(Inline), Sub]
        public static int sub(int a, int b)
            => a - b;

        [MethodImpl(Inline), Sub]
        public static uint sub(uint a, uint b)
            => a - b;

        [MethodImpl(Inline), Sub]
        public static long sub(long a, long b)
            => a - b;

        [MethodImpl(Inline), Sub]
        public static ulong sub(ulong a, ulong b)
            => a - b;

        /// <summary>
        /// Computes the difference of two 128-bit integers
        /// </summary>
        /// <param name="x">The first integer, represented via paired hi/lo components</param>
        /// <param name="y">The second integer, represented via paired hi/lo components</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> sub(in ConstPair<ulong> x, in ConstPair<ulong> y)
        {
            var lo = x.Left - y.Left;
            var borrow = x.Left < lo;
            var hi = x.Right - y.Right - z.@uint(borrow);
            return (lo,hi);
        }

        /// <summary>
        /// Computes the difference c := a - b between 128-bit unsigned integers a and b
        /// </summary>
        /// <param name="a">A reference to the left 128-bits</param>
        /// <param name="b">A reference to the right 128-bits</param>
        /// <param name="c">A reference to the target 128-bits</param>
        /// <remarks>Follows https://github.com/chfast/intx/include/intx/int128.hpp</remarks>
        [MethodImpl(Inline), Op]
        public static void sub(in ulong a, in ulong b, ref ulong c)
        {
            c = a - b;
            var borrow = a < c;
            seek(c, 1) = skip(in a, 1) - skip(in b, 1) - z.@uint(borrow);
        }
    }
}