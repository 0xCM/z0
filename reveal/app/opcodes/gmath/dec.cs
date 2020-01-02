//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        public static sbyte dec_d8i(sbyte x)
            => math.dec(x);

        public static sbyte dec_g8i(sbyte x)
            => gmath.dec(x);

        public static byte dec_d8u(byte x)
            => math.dec(x);

        public static byte dec_g8u(byte x)
            => gmath.dec(x);

        public static short dec_d16i(short x)
            => math.dec(x);

        public static short dec_g16i(short x)
            => gmath.dec(x);

        public static ushort dec_d16u(ushort x)
            => math.dec(x);

        public static ushort dec_g16u(ushort x)
            => gmath.dec(x);

        public static int dec_d32i(int x)
            => math.dec(x);

        public static int dec_g32i(int x)
            => gmath.dec(x);

        public static uint dec_d32u(uint x)
            => math.dec(x);

        public static uint dec_g32u(uint x)
            => gmath.dec(x);

        public static long dec_d64i(long x)
            => math.dec(x);

        public static long dec_g64i(long x)
            => gmath.dec(x);

        public static ulong dec_d64u(ulong x)
            => math.dec(x);

        public static ulong dec_g64u(ulong x)
            => gmath.dec(x);

        public static float dec_g32f(float x)
            => gfp.dec(x);

        public static float dec_d32f(float x)
            => fmath.dec(x);

        public static double dec_d64f(double x)
            => fmath.dec(x);

        public static double dec_g64f(double x)
            => gfp.dec(x);

    }
}