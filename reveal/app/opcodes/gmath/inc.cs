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

    partial class gmathops
    {
        public static sbyte inc_d8i(sbyte x)
            => math.inc(x);

        public static sbyte inc_g8i(sbyte x)
            => gmath.inc(x);

        public static byte inc_d8u(byte x)
            => math.inc(x);

        public static byte inc_g8u(byte x)
            => gmath.inc(x);

        public static short inc_d16i(short x)
            => math.inc(x);

        public static short inc_g16i(short x)
            => gmath.inc(x);

        public static ushort inc_d16u(ushort x)
            => math.inc(x);

        public static ushort inc_g16u(ushort x)
            => gmath.inc(x);

        public static int inc_d32i(int x)
            => math.inc(x);

        public static int inc_g32i(int x)
            => gmath.inc(x);

        public static uint inc_d32u(uint x)
            => math.inc(x);

        public static uint inc_g32u(uint x)
            => gmath.inc(x);

        public static long inc_d64i(long x)
            => math.inc(x);

        public static long inc_g64i(long x)
            => gmath.inc(x);

        public static ulong inc_d64u(ulong x)
            => math.inc(x);

        public static ulong inc_g64u(ulong x)
            => gmath.inc(x);
 
        public static float inc_g32f(float x)
            => gfp.inc(x);

        public static float inc_d32f(float x)
            => fmath.inc(x);

        public static double inc_d64f(double x)
            => fmath.inc(x);

        public static double inc_g64f(double x)
            => gfp.inc(x);
 
    }
}