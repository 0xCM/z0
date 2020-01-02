//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class gmathops
    {
        public static sbyte abs_d8i(sbyte x)
            => math.abs(x);

        public static sbyte abs_g8i(sbyte x)
            => gmath.abs(x);

        public static short abs_d16i(short x)
            => math.abs(x);

        public static short abs_g16i(short x)
            => gmath.abs(x);

        public static int abs_d32i(int x)
            => math.abs(x);

        public static int abs_g32i(int x)
            => gmath.abs(x);
        
        public static long abs_d64i(long x)
            => math.abs(x);

        public static long abs_g64i(long x)
            => gmath.abs(x);

        public static float abs_g32f(float x)
            => gfp.abs(x);

        public static float abs_d32f(float x)
            => fmath.abs(x);

        public static double abs_d64f(double x)
            => fmath.abs(x);

        public static double abs_g64f(double x)
            => gfp.abs(x);
    }
}