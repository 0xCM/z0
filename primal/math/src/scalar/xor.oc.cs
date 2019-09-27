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
        public static sbyte xor_8i(sbyte lhs, sbyte rhs)
            => math.xor(lhs,rhs);

        public static sbyte xor_g8i(sbyte lhs, sbyte rhs)
            => gmath.xor(lhs,rhs);

        public static byte xor_8u(byte lhs, byte rhs)
            => math.xor(lhs,rhs);

        public static byte xor_g8u(byte lhs, byte rhs)
            => gmath.xor(lhs,rhs);

        public static short xor_16i(short lhs, short rhs)
            => math.xor(lhs,rhs);

        public static short xor_g16i(short lhs, short rhs)
            => gmath.xor(lhs,rhs);

        public static ushort xor_16u(ushort lhs, ushort rhs)
            => math.xor(lhs,rhs);

        public static ushort xor_g16u(ushort lhs, ushort rhs)
            => gmath.xor(lhs,rhs);

        public static int xor_32i(int lhs, int rhs)
            => math.xor(lhs,rhs);

        public static int xor_g32i(int lhs, int rhs)
            => gmath.xor(lhs,rhs);

        public static uint xor_32u(uint lhs, uint rhs)
            => math.xor(lhs,rhs);

        public static uint xor_g32u(uint lhs, uint rhs)
            => gmath.xor(lhs,rhs);

        public static long xor_64i(long lhs, long rhs)
            => math.xor(lhs,rhs);

        public static long xor_g64i(long lhs, long rhs)
            => gmath.xor(lhs,rhs);

        public static ulong xor_64u(ulong lhs, ulong rhs)
            => math.xor(lhs,rhs);

        public static ulong xor_g64u(ulong lhs, ulong rhs)
            => gmath.xor(lhs,rhs);

        public static float xor_32f(float lhs, float rhs)
            => fmath.xor(lhs,rhs);

        public static float xor_g32f(float lhs, float rhs)
            => gfp.xor(lhs,rhs);

        public static double xor_64f(double lhs, double rhs)
            => fmath.xor(lhs,rhs);
        
        public static double xor_g64f(double lhs, double rhs)
            => gfp.xor(lhs,rhs);
    }

}