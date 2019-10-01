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
    }
}