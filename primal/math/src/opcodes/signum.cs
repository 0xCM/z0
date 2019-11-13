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
        public static Sign signum_d8i(sbyte x)
            => math.signum(x);

        public static Sign signum_g8i(sbyte x)
            => gmath.signum(x);

        public static Sign signum_d8u(byte x)
            => math.signum(x);

        public static Sign signum_g8u(byte x)
            => gmath.signum(x);

        public static Sign signum_d16i(short x)
            => math.signum(x);

        public static Sign signum_g16i(short x)
            => gmath.signum(x);

        public static Sign signum_d16u(ushort x)
            => math.signum(x);

        public static Sign signum_g16u(ushort x)
            => gmath.signum(x);

        public static Sign signum_d32i(int x)
            => math.signum(x);

        public static Sign signum_g32i(int x)
            => gmath.signum(x);

        public static Sign signum_d32u(uint x)
            => math.signum(x);

        public static Sign signum_g32u(uint x)
            => gmath.signum(x);

        public static Sign signum_d64i(long x)
            => math.signum(x);

        public static Sign signum_g64i(long x)
            => gmath.signum(x);

        public static Sign signum_d64u(ulong x)
            => math.signum(x);

        public static Sign signum_g64u(ulong x)
            => gmath.signum(x);
 
        public static Sign signum_g32f(float x)
            => gfp.signum(x);

        public static Sign signum_d32f(float x)
            => fmath.signum(x);

        public static Sign signum_d64f(double x)
            => fmath.signum(x);

        public static Sign signum_g64f(double x)
            => gfp.signum(x);
 

    }
}