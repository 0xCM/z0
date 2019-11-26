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
        public static bool positive_n8i(sbyte x)
            => x > 0;

        public static bool positive_g8i(sbyte x)
            => gmath.positive(x);

        public static bool positive_n8u(byte x)
            => x > 0;

        public static bool positive_g8u(byte x)
            => gmath.positive(x);

        public static bool positive_n16i(short x)
            => x > 0;

        public static bool positive_g16i(short x)
            => gmath.positive(x);

        public static bool positive_n16u(ushort x)
            => x > 0;

        public static bool positive_g16u(ushort x)
            => gmath.positive(x);

        public static bool positive_n32i(int x)
            => x > 0;

        public static bool positive_g32i(int x)
            => gmath.positive(x);

        public static bool positive_n32u(uint x)
            => x > 0;

        public static bool positive_g32u(uint x)
            => gmath.positive(x);

        public static bool positive_n64i(long x)
            => x > 0;

        public static bool positive_g64i(long x)
            => gmath.positive(x);

        public static bool positive_n64u(ulong x)
            => x > 0;

        public static bool positive_g64u(ulong x)
            => gmath.positive(x);
 
         public static bool positive_n32f(float x)
            => x > 0;

        public static bool positive_g32f(float x)
            => gmath.positive(x);

        public static bool positive_n64f(double x)
            => x > 0;

        public static bool positive_g64f(double x)
            => gmath.positive(x);

    }
}