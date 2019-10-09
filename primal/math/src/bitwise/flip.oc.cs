//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class pmoc
    {
        public static sbyte flip_d8i(sbyte x)
            => math.flip(x);

        public static sbyte flip_g8i(sbyte x)
            => gmath.flip(x);

        public static byte flip_d8u(byte x)
            => math.flip(x);

        public static byte flip_g8u(byte x)
            => gmath.flip(x);

        public static short flip_d16i(short x)
            => math.flip(x);

        public static short flip_g16i(short x)
            => gmath.flip(x);

        public static ushort flip_d16u(ushort x)
            => math.flip(x);

        public static ushort flip_g16u(ushort x)
            => gmath.flip(x);

        public static int flip_d32i(int x)
            => math.flip(x);

        public static int flip_g32i(int x)
            => gmath.flip(x);

        public static uint flip_d32u(uint x)
            => math.flip(x);

        public static uint flip_g32u(uint x)
            => gmath.flip(x);

        public static long flip_d64i(long x)
            => math.flip(x);

        public static long flip_g64i(long x)
            => gmath.flip(x);

        public static ulong flip_d64u(ulong x)
            => math.flip(x);

        public static ulong flip_g64u(ulong x)
            => gmath.flip(x);

    }
}