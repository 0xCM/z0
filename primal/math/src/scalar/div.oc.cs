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
        public static sbyte div_8i(sbyte lhs, sbyte rhs)
            => math.div(lhs,rhs);

        public static sbyte div_g8i(sbyte lhs, sbyte rhs)
            => gmath.div(lhs,rhs);

        public static byte div_8u(byte lhs, byte rhs)
            => math.div(lhs,rhs);

        public static byte div_g8u(byte lhs, byte rhs)
            => gmath.div(lhs,rhs);

        public static short div_16i(short lhs, short rhs)
            => math.div(lhs,rhs);

        public static short div_g16i(short lhs, short rhs)
            => gmath.div(lhs,rhs);

        public static ushort div_16u(ushort lhs, ushort rhs)
            => math.div(lhs,rhs);

        public static ushort div_g16u(ushort lhs, ushort rhs)
            => gmath.div(lhs,rhs);

        public static int div_32i(int lhs, int rhs)
            => math.div(lhs,rhs);

        public static int div_g32i(int lhs, int rhs)
            => gmath.div(lhs,rhs);

        public static uint div_32u(uint lhs, uint rhs)
            => math.div(lhs,rhs);

        public static uint div_g32u(uint lhs, uint rhs)
            => gmath.div(lhs,rhs);

        public static long div_64i(long lhs, long rhs)
            => math.div(lhs,rhs);

        public static long div_g64i(long lhs, long rhs)
            => gmath.div(lhs,rhs);

        public static ulong div_64u(ulong lhs, ulong rhs)
            => math.div(lhs,rhs);

        public static ulong div_g64u(ulong lhs, ulong rhs)
            => gmath.div(lhs,rhs);

        public static float div_32f(float lhs, float rhs)
            => fmath.div(lhs,rhs);

        public static float div_g32f(float lhs, float rhs)
            => gfp.div(lhs,rhs);

        public static double div_64f(double lhs, double rhs)
            => fmath.div(lhs,rhs);
        
        public static double div_g64f(double lhs, double rhs)
            => gfp.div(lhs,rhs);
    }

}