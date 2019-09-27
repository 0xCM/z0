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
        public static sbyte sub_8i(sbyte lhs, sbyte rhs)
            => math.sub(lhs,rhs);

        public static sbyte sub_g8i(sbyte lhs, sbyte rhs)
            => gmath.sub(lhs,rhs);

        public static byte sub_8u(byte lhs, byte rhs)
            => math.sub(lhs,rhs);

        public static byte sub_g8u(byte lhs, byte rhs)
            => gmath.sub(lhs,rhs);

        public static short sub_16i(short lhs, short rhs)
            => math.sub(lhs,rhs);

        public static short sub_g16i(short lhs, short rhs)
            => gmath.sub(lhs,rhs);

        public static ushort sub_16u(ushort lhs, ushort rhs)
            => math.sub(lhs,rhs);

        public static ushort sub_g16u(ushort lhs, ushort rhs)
            => gmath.sub(lhs,rhs);

        public static int sub_32i(int lhs, int rhs)
            => math.sub(lhs,rhs);

        public static int sub_g32i(int lhs, int rhs)
            => gmath.sub(lhs,rhs);

        public static uint sub_32u(uint lhs, uint rhs)
            => math.sub(lhs,rhs);

        public static uint sub_g32u(uint lhs, uint rhs)
            => gmath.sub(lhs,rhs);

        public static long sub_64i(long lhs, long rhs)
            => math.sub(lhs,rhs);

        public static long sub_g64i(long lhs, long rhs)
            => gmath.sub(lhs,rhs);

        public static ulong sub_64u(ulong lhs, ulong rhs)
            => math.sub(lhs,rhs);

        public static ulong sub_g64u(ulong lhs, ulong rhs)
            => gmath.sub(lhs,rhs);

        public static float sub_32f(float lhs, float rhs)
            => fmath.sub(lhs,rhs);

        public static float sub_g32f(float lhs, float rhs)
            => gfp.sub(lhs,rhs);

        public static double sub_64f(double lhs, double rhs)
            => fmath.sub(lhs,rhs);
        
        public static double sub_g64f(double lhs, double rhs)
            => gfp.sub(lhs,rhs);
    }

}