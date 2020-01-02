//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class gmathops
    {
        public static bit gt_d8i(sbyte a, sbyte b)
            => math.gt(a,b);

        public static bit gt_g8i(sbyte a, sbyte b)
            => gmath.gt(a,b);

        public static bit gt_d8u(byte a, byte b)
            => math.gt(a,b);

        public static bit gt_g8u(byte a, byte b)
            => gmath.gt(a,b);

        public static bit gt_d16i(short a, short b)
            => math.gt(a,b);

        public static bit gt_g16i(short a, short b)
            => gmath.gt(a,b);

        public static bit gt_d16u(ushort a, ushort b)
            => math.gt(a,b);

        public static bit gt_g16u(ushort a, ushort b)
            => gmath.gt(a,b);

        public static bit gt_d32i(int a, int b)
            => math.gt(a,b);

        public static bit gt_g32i(int a, int b)
            => gmath.gt(a,b);

        public static bit gt_d32u(uint a, uint b)
            => math.gt(a,b);

        public static bit gt_g32u(uint a, uint b)
            => gmath.gt(a,b);

        public static bit gt_d64i(long a, long b)
            => math.gt(a,b);

        public static bit gt_g64i(long a, long b)
            => gmath.gt(a,b);

        public static bit gt_d64u(ulong a, ulong b)
            => math.gt(a,b);

        public static bit gt_g64u(ulong a, ulong b)
            => gmath.gt(a,b);

        public static bit gt_d32f(float a, float b)
            => fmath.gt(a,b);

        public static bit gt_g32f(float a, float b)
            => gfp.gt(a,b);

        public static bit gt_d64f(double a, double b)
            => fmath.gt(a,b);
        
        public static bit gt_g64f(double a, double b)
            => gfp.gt(a,b);
 
         public static bit gteq_d8i(sbyte a, sbyte b)
            => math.gteq(a,b);

        public static bit gteq_g8i(sbyte a, sbyte b)
            => gmath.gteq(a,b);

        public static bit gteq_d8u(byte a, byte b)
            => math.gteq(a,b);

        public static bit gteq_g8u(byte a, byte b)
            => gmath.gteq(a,b);

        public static bit gteq_d16i(short a, short b)
            => math.gteq(a,b);

        public static bit gteq_g16i(short a, short b)
            => gmath.gteq(a,b);

        public static bit gteq_d16u(ushort a, ushort b)
            => math.gteq(a,b);

        public static bit gteq_g16u(ushort a, ushort b)
            => gmath.gteq(a,b);

        public static bit gteq_d32i(int a, int b)
            => math.gteq(a,b);

        public static bit gteq_g32i(int a, int b)
            => gmath.gteq(a,b);

        public static bit gteq_d32u(uint a, uint b)
            => math.gteq(a,b);

        public static bit gteq_g32u(uint a, uint b)
            => gmath.gteq(a,b);

        public static bit gteq_d64i(long a, long b)
            => math.gteq(a,b);

        public static bit gteq_g64i(long a, long b)
            => gmath.gteq(a,b);

        public static bit gteq_d64u(ulong a, ulong b)
            => math.gteq(a,b);

        public static bit gteq_g64u(ulong a, ulong b)
            => gmath.gteq(a,b);

        public static bit gteq_d32f(float a, float b)
            => fmath.gteq(a,b);

        public static bit gteq_g32f(float a, float b)
            => gfp.gteq(a,b);

        public static bit gteq_d64f(double a, double b)
            => fmath.gteq(a,b);
        
        public static bit gteq_g64f(double a, double b)
            => gfp.gteq(a,b);
 
    }

}