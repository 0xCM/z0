//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    partial class math
    {
        [MethodImpl(Inline), Op]
        public static sbyte add(sbyte a, sbyte b)
            => (sbyte)(a + b);

        [MethodImpl(Inline), Op]
        public static byte add(byte a, byte b)
            => (byte)(a + b);

        [MethodImpl(Inline), Op]
        public static short add(short a, short b)
            => (short)(a + b);

        [MethodImpl(Inline), Op]
        public static ushort add(ushort a, ushort b)
            => (ushort)(a + b);

        [MethodImpl(Inline), Op]
        public static int add(int a, int b)
            => a + b;

        [MethodImpl(Inline), Op]
        public static uint add(uint a, uint b)
            => a + b;

        [MethodImpl(Inline), Op]
        public static long add(long a, long b)
            => a + b;

        [MethodImpl(Inline), Op]
        public static ulong add(ulong a, ulong b)
            => a + b;
    }
}