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
        public static sbyte min_d8i(sbyte lhs, sbyte rhs)
            => math.min(lhs,rhs);

        public static sbyte min_g8i(sbyte lhs, sbyte rhs)
            => gmath.min(lhs,rhs);

        public static byte min_d8u(byte lhs, byte rhs)
            => math.min(lhs,rhs);

        public static byte min_g8u(byte lhs, byte rhs)
            => gmath.min(lhs,rhs);

        public static short min_d16i(short lhs, short rhs)
            => math.min(lhs,rhs);

        public static short min_g16i(short lhs, short rhs)
            => gmath.min(lhs,rhs);

        public static ushort min_d16u(ushort lhs, ushort rhs)
            => math.min(lhs,rhs);

        public static ushort min_g16u(ushort lhs, ushort rhs)
            => gmath.min(lhs,rhs);

        public static int min_d32i(int lhs, int rhs)
            => math.min(lhs,rhs);

        public static int min_g32i(int lhs, int rhs)
            => gmath.min(lhs,rhs);

        public static uint min_d32u(uint lhs, uint rhs)
            => math.min(lhs,rhs);

        public static uint min_g32u(uint lhs, uint rhs)
            => gmath.min(lhs,rhs);

        public static long min_d64i(long lhs, long rhs)
            => math.min(lhs,rhs);

        public static long min_g64i(long lhs, long rhs)
            => gmath.min(lhs,rhs);

        public static ulong min_d64u(ulong lhs, ulong rhs)
            => math.min(lhs,rhs);

        public static ulong min_g64u(ulong lhs, ulong rhs)
            => gmath.min(lhs,rhs);

        public static float min_d32f(float lhs, float rhs)
            => fmath.min(lhs,rhs);

        public static float min_g32f(float lhs, float rhs)
            => gfp.min(lhs,rhs);

        public static double min_d64f(double lhs, double rhs)
            => fmath.min(lhs,rhs);
        
        public static double min_g64f(double lhs, double rhs)
            => gfp.min(lhs,rhs);
    }

}