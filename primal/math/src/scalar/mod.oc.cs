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
        public static sbyte mod_8i(sbyte lhs, sbyte rhs)
            => math.mod(lhs,rhs);

        public static sbyte mod_g8i(sbyte lhs, sbyte rhs)
            => gmath.mod(lhs,rhs);

        public static byte mod_8u(byte lhs, byte rhs)
            => math.mod(lhs,rhs);

        public static byte mod_g8u(byte lhs, byte rhs)
            => gmath.mod(lhs,rhs);

        public static short mod_16i(short lhs, short rhs)
            => math.mod(lhs,rhs);

        public static short mod_g16i(short lhs, short rhs)
            => gmath.mod(lhs,rhs);

        public static ushort mod_16u(ushort lhs, ushort rhs)
            => math.mod(lhs,rhs);

        public static ushort mod_g16u(ushort lhs, ushort rhs)
            => gmath.mod(lhs,rhs);

        public static int mod_32i(int lhs, int rhs)
            => math.mod(lhs,rhs);

        public static int mod_g32i(int lhs, int rhs)
            => gmath.mod(lhs,rhs);

        public static uint mod_32u(uint lhs, uint rhs)
            => math.mod(lhs,rhs);

        public static uint mod_g32u(uint lhs, uint rhs)
            => gmath.mod(lhs,rhs);

        public static long mod_64i(long lhs, long rhs)
            => math.mod(lhs,rhs);

        public static long mod_g64i(long lhs, long rhs)
            => gmath.mod(lhs,rhs);

        public static ulong mod_64u(ulong lhs, ulong rhs)
            => math.mod(lhs,rhs);

        public static ulong mod_g64u(ulong lhs, ulong rhs)
            => gmath.mod(lhs,rhs);

        public static float mod_32f(float lhs, float rhs)
            => fmath.mod(lhs,rhs);

        public static float mod_g32f(float lhs, float rhs)
            => gfp.mod(lhs,rhs);

        public static double mod_64f(double lhs, double rhs)
            => fmath.mod(lhs,rhs);
        
        public static double mod_g64f(double lhs, double rhs)
            => gfp.mod(lhs,rhs);
    }

}