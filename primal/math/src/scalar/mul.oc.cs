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
        public static sbyte mul_8i(sbyte lhs, sbyte rhs)
            => math.mul(lhs,rhs);

        public static sbyte mul_g8i(sbyte lhs, sbyte rhs)
            => gmath.mul(lhs,rhs);

        public static byte mul_8u(byte lhs, byte rhs)
            => math.mul(lhs,rhs);

        public static byte mul_g8u(byte lhs, byte rhs)
            => gmath.mul(lhs,rhs);

        public static short mul_16i(short lhs, short rhs)
            => math.mul(lhs,rhs);

        public static short mul_g16i(short lhs, short rhs)
            => gmath.mul(lhs,rhs);

        public static ushort mul_16u(ushort lhs, ushort rhs)
            => math.mul(lhs,rhs);

        public static ushort mul_g16u(ushort lhs, ushort rhs)
            => gmath.mul(lhs,rhs);

        public static int mul_32i(int lhs, int rhs)
            => math.mul(lhs,rhs);

        public static int mul_g32i(int lhs, int rhs)
            => gmath.mul(lhs,rhs);

        public static uint mul_32u(uint lhs, uint rhs)
            => math.mul(lhs,rhs);

        public static uint mul_g32u(uint lhs, uint rhs)
            => gmath.mul(lhs,rhs);

        public static long mul_64i(long lhs, long rhs)
            => math.mul(lhs,rhs);

        public static long mul_g64i(long lhs, long rhs)
            => gmath.mul(lhs,rhs);

        public static ulong mul_64u(ulong lhs, ulong rhs)
            => math.mul(lhs,rhs);

        public static ulong mul_g64u(ulong lhs, ulong rhs)
            => gmath.mul(lhs,rhs);

        public static float mul_32f(float lhs, float rhs)
            => fmath.mul(lhs,rhs);

        public static float mul_g32f(float lhs, float rhs)
            => gfp.mul(lhs,rhs);

        public static double mul_64f(double lhs, double rhs)
            => fmath.mul(lhs,rhs);
        
        public static double mul_g64f(double lhs, double rhs)
            => gfp.mul(lhs,rhs);
    }

}