//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class gmoc
    {
        public static sbyte not_d8i(sbyte x)
            => math.not(x);

        public static sbyte not_g8i(sbyte x)
            => gmath.not(x);

        public static byte not_d8u(byte x)
            => math.not(x);

        public static byte not_g8u(byte x)
            => gmath.not(x);

        public static short not_d16i(short x)
            => math.not(x);

        public static short not_g16i(short x)
            => gmath.not(x);

        public static ushort not_d16u(ushort x)
            => math.not(x);

        public static ushort not_g16u(ushort x)
            => gmath.not(x);

        public static int not_d32i(int x)
            => math.not(x);

        public static int not_g32i(int x)
            => gmath.not(x);

        public static uint not_d32u(uint x)
            => math.not(x);

        public static uint not_g32u(uint x)
            => gmath.not(x);

        public static long not_d64i(long x)
            => math.not(x);

        public static long not_g64i(long x)
            => gmath.not(x);

        public static ulong not_d64u(ulong x)
            => math.not(x);

        public static ulong not_g64u(ulong x)
            => gmath.not(x);

    }
}