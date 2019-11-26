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
        public static sbyte square_d8i(sbyte x)
            => math.square(x);

        public static sbyte square_g8i(sbyte x)
            => gmath.square(x);

        public static byte square_d8u(byte x)
            => math.square(x);

        public static byte square_g8u(byte x)
            => gmath.square(x);

        public static short square_d16i(short x)
            => math.square(x);

        public static short square_g16i(short x)
            => gmath.square(x);

        public static ushort square_d16u(ushort x)
            => math.square(x);

        public static ushort square_g16u(ushort x)
            => gmath.square(x);

        public static int square_d32i(int x)
            => math.square(x);

        public static int square_g32i(int x)
            => gmath.square(x);

        public static uint square_d32u(uint x)
            => math.square(x);

        public static uint square_g32u(uint x)
            => gmath.square(x);

        public static long square_d64i(long x)
            => math.square(x);

        public static long square_g64i(long x)
            => gmath.square(x);

        public static ulong square_d64u(ulong x)
            => math.square(x);

        public static ulong square_g64u(ulong x)
            => gmath.square(x);
 
         public static float square_d32f(float x)
            => fmath.square(x);

        public static float square_g32f(float x)
            => gfp.square(x);

        public static double square_d64f(double x)
            => fmath.square(x);

        public static double square_g64f(double x)
            => gfp.square(x);

    }
}