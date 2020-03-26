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
        [MethodImpl(Inline), Xnor]
        public static sbyte xnor(sbyte a, sbyte b)
            => not(xor(a,b));

        [MethodImpl(Inline), Xnor]
        public static byte xnor(byte a, byte b)
            => not(xor(a,b));

        [MethodImpl(Inline), Xnor]
        public static short xnor(short a, short b)
            => not(xor(a,b));

        [MethodImpl(Inline), Xnor]
        public static ushort xnor(ushort a, ushort b)
            => not(xor(a,b));

        [MethodImpl(Inline), Xnor]
        public static int xnor(int a, int b)
            => ~ (a ^ b);

        [MethodImpl(Inline), Xnor]
        public static uint xnor(uint a, uint b)
            => ~ (a ^ b);

        [MethodImpl(Inline), Xnor]
        public static long xnor(long a, long b)
            => ~ (a ^ b);

        [MethodImpl(Inline), Xnor]
        public static ulong xnor(ulong a, ulong b)
            => ~ (a ^ b);

    }

}