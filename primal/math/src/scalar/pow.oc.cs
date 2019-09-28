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
        public static sbyte pow_b8i(sbyte b, uint exp)
            => math.pow(b,exp);

        public static sbyte pow_g8i(sbyte b, uint exp)
            => gmath.pow(b,exp);

        public static byte pow_b8u(byte b, uint exp)
            => math.pow(b,exp);

        public static byte pow_g8u(byte b, uint exp)
            => gmath.pow(b,exp);

        public static short pow_b16i(short b, uint exp)
            => math.pow(b,exp);

        public static short pow_g16i(short b, uint exp)
            => gmath.pow(b,exp);

        public static ushort pow_b16u(ushort b, uint exp)
            => math.pow(b,exp);

        public static ushort pow_g16u(ushort b, uint exp)
            => gmath.pow(b,exp);

        public static int pow_b32i(int b, uint exp)
            => math.pow(b,exp);

        public static int pow_g32i(int b, uint exp)
            => gmath.pow(b,exp);

        public static uint pow_b32u(uint b, uint exp)
            => math.pow(b,exp);

        public static uint pow_g32u(uint b, uint exp)
            => gmath.pow(b,exp);

        public static long pow_b64i(long b, uint exp)
            => math.pow(b,exp);

        public static long pow_g64i(long b, uint exp)
            => gmath.pow(b,exp);

        public static ulong pow_b64u(ulong b, uint exp)
            => math.pow(b,exp);

        public static ulong pow_g64u(ulong b, uint exp)
            => gmath.pow(b,exp);

        public static float pow_d32f(float b, uint exp)
            => fmath.pow(b,exp);

        public static float pow_g32f(float b, uint exp)
            => gfp.pow(b,exp);

        public static double pow_d64f(double b, uint exp)
            => fmath.pow(b,exp);

        public static double pow_g64f(double b, uint exp)
            => gfp.pow(b,exp);

    }

}