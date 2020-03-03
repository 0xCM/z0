//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;    

    partial class math
    {
        [MethodImpl(Inline), Op]
        public static sbyte xnor(sbyte a, sbyte b)
            => not(xor(a,b));

        [MethodImpl(Inline), Op]
        public static byte xnor(byte a, byte b)
            => not(xor(a,b));

        [MethodImpl(Inline), Op]
        public static short xnor(short a, short b)
            => not(xor(a,b));

        [MethodImpl(Inline), Op]
        public static ushort xnor(ushort a, ushort b)
            => not(xor(a,b));

        [MethodImpl(Inline), Op]
        public static int xnor(int a, int b)
            => ~ (a ^ b);

        [MethodImpl(Inline), Op]
        public static uint xnor(uint a, uint b)
            => ~ (a ^ b);

        [MethodImpl(Inline), Op]
        public static long xnor(long a, long b)
            => ~ (a ^ b);

        [MethodImpl(Inline), Op]
        public static ulong xnor(ulong a, ulong b)
            => ~ (a ^ b);

    }

}