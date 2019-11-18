//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class gmoc
    {
        public static sbyte max_d8i(sbyte a, sbyte b)
            => math.max(a,b);

        public static sbyte max_g8i(sbyte a, sbyte b)
            => gmath.max(a,b);

        public static byte max_d8u(byte a, byte b)
            => math.max(a,b);

        public static byte max_g8u(byte a, byte b)
            => gmath.max(a,b);

        public static short max_d16i(short a, short b)
            => math.max(a,b);

        public static short max_g16i(short a, short b)
            => gmath.max(a,b);

        public static ushort max_d16u(ushort a, ushort b)
            => math.max(a,b);

        public static ushort max_g16u(ushort a, ushort b)
            => gmath.max(a,b);

        public static int max_d32i(int a, int b)
            => math.max(a,b);

        public static int max_g32i(int a, int b)
            => gmath.max(a,b);

        public static uint max_d32u(uint a, uint b)
            => math.max(a,b);

        public static uint max_g32u(uint a, uint b)
            => gmath.max(a,b);

        public static long max_d64i(long a, long b)
            => math.max(a,b);

        public static long max_g64i(long a, long b)
            => gmath.max(a,b);

        public static ulong max_d64u(ulong a, ulong b)
            => math.max(a,b);

        public static ulong max_g64u(ulong a, ulong b)
            => gmath.max(a,b);
            
        public static float max_d32f(float lhs, float rhs)
            => fmath.max(lhs,rhs);

        public static float max_g32f(float lhs, float rhs)
            => gfp.max(lhs,rhs);

        public static double max_d64f(double lhs, double rhs)
            => fmath.max(lhs,rhs);
        
        public static double max_g64f(double lhs, double rhs)
            => gfp.max(lhs,rhs);

    }
}