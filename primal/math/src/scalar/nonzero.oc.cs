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
        public static bool nonzero_n8i(sbyte x)
            => !x.Equals(0);

        public static bool nonzero_g8i(sbyte x)
            => gmath.nonzero(x);

        public static bool nonzero_n8u(byte x)
            => !x.Equals(0);

        public static bool nonzero_g8u(byte x)
            => gmath.nonzero(x);

        public static bool nonzero_n16i(short x)
            => !x.Equals(0);

        public static bool nonzero_g16i(short x)
            => gmath.nonzero(x);

        public static bool nonzero_n16u(ushort x)
            => !x.Equals(0);

        public static bool nonzero_g16u(ushort x)
            => gmath.nonzero(x);

        public static bool nonzero_n32i(int x)
            => !x.Equals(0);

        public static bool nonzero_g32i(int x)
            => gmath.nonzero(x);

        public static bool nonzero_n32u(uint x)
            => !x.Equals(0);

        public static bool nonzero_g32u(uint x)
            => gmath.nonzero(x);

        public static bool nonzero_n64i(long x)
            => !x.Equals(0);

        public static bool nonzero_g64i(long x)
            => gmath.nonzero(x);

        public static bool nonzero_n64u(ulong x)
            => !x.Equals(0);

        public static bool nonzero_g64u(ulong x)
            => gmath.nonzero(x);

        public static bool nonzero_n32f(float x)
            => x != 0;

        public static bool nonzero_g32f(float x)
            => gmath.nonzero(x);

        public static bool nonzero_n64f(double x)
            => x != 0;

        public static bool nonzero_g64f(double x)
            => gmath.nonzero(x);

    }
}