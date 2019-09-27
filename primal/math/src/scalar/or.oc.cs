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
        public static sbyte or_8i(sbyte lhs, sbyte rhs)
            => math.or(lhs,rhs);

        public static sbyte or_g8i(sbyte lhs, sbyte rhs)
            => gmath.or(lhs,rhs);

        public static byte or_8u(byte lhs, byte rhs)
            => math.or(lhs,rhs);

        public static byte or_g8u(byte lhs, byte rhs)
            => gmath.or(lhs,rhs);

        public static short or_16i(short lhs, short rhs)
            => math.or(lhs,rhs);

        public static short or_g16i(short lhs, short rhs)
            => gmath.or(lhs,rhs);

        public static ushort or_16u(ushort lhs, ushort rhs)
            => math.or(lhs,rhs);

        public static ushort or_g16u(ushort lhs, ushort rhs)
            => gmath.or(lhs,rhs);

        public static int or_32i(int lhs, int rhs)
            => math.or(lhs,rhs);

        public static int or_g32i(int lhs, int rhs)
            => gmath.or(lhs,rhs);

        public static uint or_32u(uint lhs, uint rhs)
            => math.or(lhs,rhs);

        public static uint or_g32u(uint lhs, uint rhs)
            => gmath.or(lhs,rhs);

        public static long or_64i(long lhs, long rhs)
            => math.or(lhs,rhs);

        public static long or_g64i(long lhs, long rhs)
            => gmath.or(lhs,rhs);

        public static ulong or_64u(ulong lhs, ulong rhs)
            => math.or(lhs,rhs);

        public static ulong or_g64u(ulong lhs, ulong rhs)
            => gmath.or(lhs,rhs);

        public static float or_32f(float lhs, float rhs)
            => fmath.or(lhs,rhs);

        public static float or_g32f(float lhs, float rhs)
            => gfp.or(lhs,rhs);

        public static double or_64f(double lhs, double rhs)
            => fmath.or(lhs,rhs);
        
        public static double or_g64f(double lhs, double rhs)
            => gfp.or(lhs,rhs);
    }

}