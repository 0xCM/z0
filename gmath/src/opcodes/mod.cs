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
        public static sbyte mod_n8i(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs % rhs);

        public static sbyte mod_d8i(sbyte lhs, sbyte rhs)
            => math.mod(lhs,rhs);

        public static sbyte mod_g8i(sbyte lhs, sbyte rhs)
            => gmath.mod(lhs,rhs);

        public static byte mod_n8u(byte lhs, byte rhs)
            => (byte)(lhs % rhs);

        public static byte mod_d8u(byte lhs, byte rhs)
            => math.mod(lhs,rhs);

        public static byte mod_g8u(byte lhs, byte rhs)
            => gmath.mod(lhs,rhs);

        public static short mod_d16i(short lhs, short rhs)
            => math.mod(lhs,rhs);

        public static short mod_g16i(short lhs, short rhs)
            => gmath.mod(lhs,rhs);

        public static ushort mod_d16u(ushort lhs, ushort rhs)
            => math.mod(lhs,rhs);

        public static ushort mod_g16u(ushort lhs, ushort rhs)
            => gmath.mod(lhs,rhs);

        public static int mod_d32i(int lhs, int rhs)
            => math.mod(lhs,rhs);

        public static int mod_g32i(int lhs, int rhs)
            => gmath.mod(lhs,rhs);

        public static uint mod_d32u(uint lhs, uint rhs)
            => math.mod(lhs,rhs);

        public static uint mod_g32u(uint lhs, uint rhs)
            => gmath.mod(lhs,rhs);

        public static long mod_d64i(long lhs, long rhs)
            => math.mod(lhs,rhs);

        public static long mod_g64i(long lhs, long rhs)
            => gmath.mod(lhs,rhs);

        public static ulong mod_d64u(ulong lhs, ulong rhs)
            => math.mod(lhs,rhs);

        public static ulong mod_g64u(ulong lhs, ulong rhs)
            => gmath.mod(lhs,rhs);

        public static float mod_d32f(float lhs, float rhs)
            => fmath.mod(lhs,rhs);

        public static float mod_g32f(float lhs, float rhs)
            => gfp.mod(lhs,rhs);

        public static double mod_d64f(double lhs, double rhs)
            => fmath.mod(lhs,rhs);
        
        public static double mod_g64f(double lhs, double rhs)
            => gfp.mod(lhs,rhs);
    }

}