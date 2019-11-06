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
        public static sbyte or_d8i(sbyte lhs, sbyte rhs)
            => math.or(lhs,rhs);

        public static sbyte or_g8i(sbyte lhs, sbyte rhs)
            => gmath.or(lhs,rhs);

        public static byte or_d8u(byte lhs, byte rhs)
            => math.or(lhs,rhs);

        public static byte or_g8u(byte lhs, byte rhs)
            => gmath.or(lhs,rhs);

        public static short or_d16i(short lhs, short rhs)
            => math.or(lhs,rhs);

        public static short or_g16i(short lhs, short rhs)
            => gmath.or(lhs,rhs);

        public static ushort or_d16u(ushort lhs, ushort rhs)
            => math.or(lhs,rhs);

        public static ushort or_g16u(ushort lhs, ushort rhs)
            => gmath.or(lhs,rhs);

        public static int or_d32i(int lhs, int rhs)
            => math.or(lhs,rhs);

        public static int or_g32i(int lhs, int rhs)
            => gmath.or(lhs,rhs);

        public static uint or_d32u(uint lhs, uint rhs)
            => math.or(lhs,rhs);

        public static uint or_g32u(uint lhs, uint rhs)
            => gmath.or(lhs,rhs);

        public static long or_d64i(long lhs, long rhs)
            => math.or(lhs,rhs);

        public static long or_g64i(long lhs, long rhs)
            => gmath.or(lhs,rhs);

        public static ulong or_d64u(ulong lhs, ulong rhs)
            => math.or(lhs,rhs);

        public static ulong or_g64u(ulong lhs, ulong rhs)
            => gmath.or(lhs,rhs);

        public static float or_d32f(float lhs, float rhs)
            => fmath.or(lhs,rhs);

        public static float or_g32f(float lhs, float rhs)
            => gfp.or(lhs,rhs);

        public static double or_d64f(double lhs, double rhs)
            => fmath.or(lhs,rhs);
        
        public static double or_g64f(double lhs, double rhs)
            => gfp.or(lhs,rhs);
    }

}