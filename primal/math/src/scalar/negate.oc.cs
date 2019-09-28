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

    partial class soc
    {
        public static sbyte negate_d8i(sbyte x)
            => math.negate(x);

        public static sbyte negate_g8i(sbyte x)
            => gmath.negate(x);

        public static byte negate_d8u(byte x)
            => math.negate(x);

        public static byte negate_g8u(byte x)
            => gmath.negate(x);

        public static short negate_d16i(short x)
            => math.negate(x);

        public static short negate_g16i(short x)
            => gmath.negate(x);

        public static ushort negate_d16u(ushort x)
            => math.negate(x);

        public static ushort negate_g16u(ushort x)
            => gmath.negate(x);

        public static int negate_d32i(int x)
            => math.negate(x);

        public static int negate_g32i(int x)
            => gmath.negate(x);

        public static uint negate_d32u(uint x)
            => math.negate(x);

        public static uint negate_g32u(uint x)
            => gmath.negate(x);

        public static long negate_d64i(long x)
            => math.negate(x);

        public static long negate_g64i(long x)
            => gmath.negate(x);

        public static ulong negate_d64u(ulong x)
            => math.negate(x);

        public static ulong negate_g64u(ulong x)
            => gmath.negate(x);

        public static float negate_g32f(float x)
            => gfp.negate(x);

        public static float negate_d32f(float x)
            => fmath.negate(x);

        public static double negate_d64f(double x)
            => fmath.negate(x);

        public static double negate_g64f(double x)
            => gfp.negate(x);

    }
}