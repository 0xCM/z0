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
        public static bool negative_n8i(sbyte x)
            => x < 0;

        public static bool negative_g8i(sbyte x)
            => gmath.negative(x);

        public static bool negative_n8u(byte x)
            => x < 0;

        public static bool negative_g8u(byte x)
            => gmath.negative(x);

        public static bool negative_n16i(short x)
            => x < 0;

        public static bool negative_g16i(short x)
            => gmath.negative(x);

        public static bool negative_n16u(ushort x)
            => x < 0;

        public static bool negative_g16u(ushort x)
            => gmath.negative(x);

        public static bool negative_n32i(int x)
            => x < 0;

        public static bool negative_g32i(int x)
            => gmath.negative(x);

        public static bool negative_n32u(uint x)
            => x < 0;

        public static bool negative_g32u(uint x)
            => gmath.negative(x);

        public static bool negative_n64i(long x)
            => x < 0;

        public static bool negative_g64i(long x)
            => gmath.negative(x);

        public static bool negative_n64u(ulong x)
            => x < 0;

        public static bool negative_g64u(ulong x)
            => gmath.negative(x);

        public static bool negative_n32f(float x)
            => x < 0;

        public static bool negative_g32f(float x)
            => gmath.negative(x);

        public static bool negative_n64f(double x)
            => x < 0;

        public static bool negative_g64f(double x)
            => gmath.negative(x);

    }
}