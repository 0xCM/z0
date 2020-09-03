//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class math
    {
        [MethodImpl(Inline)]
        public static sbyte nor(sbyte a, sbyte b)
            => not(or(a,b));

        [MethodImpl(Inline)]
        public static byte nor(byte a, byte b)
            => not(or(a,b));

        [MethodImpl(Inline)]
        public static short nor(short a, short b)
            => not(or(a,b));

        [MethodImpl(Inline)]
        public static ushort nor(ushort a, ushort b)
            => not(or(a,b));

        [MethodImpl(Inline)]
        public static int nor(int a, int b)
            => ~ (a | b);

        [MethodImpl(Inline)]
        public static uint nor(uint a, uint b)
            => ~ (a | b);

        [MethodImpl(Inline)]
        public static long nor(long a, long b)
            => ~ (a | b);

        [MethodImpl(Inline)]
        public static ulong nor(ulong a, ulong b)
            => ~ (a | b);

        [MethodImpl(Inline), Op]
        public static ConstPair<ulong> nor(in ConstPair<ulong> x, in ConstPair<ulong> y)
            => not(math.or(x,y));
    }
}