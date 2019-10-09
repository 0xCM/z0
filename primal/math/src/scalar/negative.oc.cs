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
        public static bool negative_d8i(sbyte x)
            => math.negative(x);

        public static bool negative_g8i(sbyte x)
            => gmath.negative(x);

        public static bool negative_d16i(short x)
            => math.negative(x);

        public static bool negative_g16i(short x)
            => gmath.negative(x);

        public static bool negative_d32i(int x)
            => math.negative(x);

        public static bool negative_g32i(int x)
            => gmath.negative(x);

        public static bool negative_d64i(long x)
            => math.negative(x);

        public static bool negative_g64i(long x)
            => gmath.negative(x);

        public static bool negative_d32f(float x)
            => math.negative(x);

        public static bool negative_g32f(float x)
            => gmath.negative(x);


        public static bool negative_d64f(double x)
            => math.negative(x);

        public static bool negative_g64f(double x)
            => gmath.negative(x);

    }
}