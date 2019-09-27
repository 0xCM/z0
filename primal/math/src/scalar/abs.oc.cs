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
        public static short abs_8i(short x)
            => math.abs(x);

        public static short abs_g8i(short x)
            => gmath.abs(x);

        public static short abs_16i(short x)
            => math.abs(x);

        public static short abs_g16i(short x)
            => gmath.abs(x);

        public static int abs_32i(int x)
            => math.abs(x);

        public static int abs_g32i(int x)
            => gmath.abs(x);
        
        public static long abs_64i(long x)
            => math.abs(x);

        public static float abs_g32f(float x)
            => gfp.abs(x);

        public static long abs_g64i(long x)
            => gmath.abs(x);

        public static float abs_32f(float x)
            => fmath.abs(x);

        public static double abs_64f(double x)
            => fmath.abs(x);

        public static double abs_g64f(double x)
            => gfp.abs(x);

    }
}