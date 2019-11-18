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
        public static sbyte and_d8i(sbyte lhs, sbyte rhs)
            => math.and(lhs,rhs);

        public static sbyte and_g8i(sbyte lhs, sbyte rhs)
            => gmath.and(lhs,rhs);

        public static byte and_d8u(byte lhs, byte rhs)
            => math.and(lhs,rhs);

        public static byte and_g8u(byte lhs, byte rhs)
            => gmath.and(lhs,rhs);

        public static short and_d16i(short lhs, short rhs)
            => math.and(lhs,rhs);

        public static short and_g16i(short lhs, short rhs)
            => gmath.and(lhs,rhs);

        public static ushort and_d16u(ushort lhs, ushort rhs)
            => math.and(lhs,rhs);

        public static ushort and_g16u(ushort lhs, ushort rhs)
            => gmath.and(lhs,rhs);

        public static int and_d32i(int lhs, int rhs)
            => math.and(lhs,rhs);

        public static int and_g32i(int lhs, int rhs)
            => gmath.and(lhs,rhs);

        public static uint and_d32u(uint lhs, uint rhs)
            => math.and(lhs,rhs);

        public static uint and_g32u(uint lhs, uint rhs)
            => gmath.and(lhs,rhs);

        public static long and_d64i(long lhs, long rhs)
            => math.and(lhs,rhs);

        public static long and_g64i(long lhs, long rhs)
            => gmath.and(lhs,rhs);

        public static ulong and_d64u(ulong lhs, ulong rhs)
            => math.and(lhs,rhs);

        public static ulong and_g64u(ulong lhs, ulong rhs)
            => gmath.and(lhs,rhs);

        public static float and_d32f(float lhs, float rhs)
            => fmath.and(lhs,rhs);

        public static float and_g32f(float lhs, float rhs)
            => gfp.and(lhs,rhs);

        public static double and_d64f(double lhs, double rhs)
            => fmath.and(lhs,rhs);
        
        public static double and_g64f(double lhs, double rhs)
            => gfp.and(lhs,rhs);
    }

}