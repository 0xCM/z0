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
        public static bit eq_d8i(sbyte lhs, sbyte rhs)
            => math.eq(lhs,rhs);

        public static bit eq_g8i(sbyte lhs, sbyte rhs)
            => gmath.eq(lhs,rhs);

        public static bit eq_d8u(byte lhs, byte rhs)
            => math.eq(lhs,rhs);

        public static bit eq_g8u(byte lhs, byte rhs)
            => gmath.eq(lhs,rhs);

        public static bit eq_d16i(short lhs, short rhs)
            => math.eq(lhs,rhs);

        public static bit eq_g16i(short lhs, short rhs)
            => gmath.eq(lhs,rhs);

        public static bit eq_d16u(ushort lhs, ushort rhs)
            => math.eq(lhs,rhs);

        public static bit eq_g16u(ushort lhs, ushort rhs)
            => gmath.eq(lhs,rhs);

        public static bit eq_d32i(int lhs, int rhs)
            => math.eq(lhs,rhs);

        public static bit eq_g32i(int lhs, int rhs)
            => gmath.eq(lhs,rhs);

        public static bit eq_d32u(uint lhs, uint rhs)
            => math.eq(lhs,rhs);

        public static bit eq_g32u(uint lhs, uint rhs)
            => gmath.eq(lhs,rhs);

        public static bit eq_d64i(long lhs, long rhs)
            => math.eq(lhs,rhs);

        public static bit eq_g64i(long lhs, long rhs)
            => gmath.eq(lhs,rhs);

        public static bit eq_d64u(ulong lhs, ulong rhs)
            => math.eq(lhs,rhs);

        public static bit eq_g64u(ulong lhs, ulong rhs)
            => gmath.eq(lhs,rhs);

        public static bit eq_d32f(float lhs, float rhs)
            => fmath.eq(lhs,rhs);

        public static bit eq_g32f(float lhs, float rhs)
            => gfp.eq(lhs,rhs);

        public static bit eq_d64f(double lhs, double rhs)
            => fmath.eq(lhs,rhs);
        
        public static bit eq_g64f(double lhs, double rhs)
            => gfp.eq(lhs,rhs);
 
         public static bit neq_d8i(sbyte lhs, sbyte rhs)
            => math.neq(lhs,rhs);

        public static bit neq_g8i(sbyte lhs, sbyte rhs)
            => gmath.neq(lhs,rhs);

        public static bit neq_d8u(byte lhs, byte rhs)
            => math.neq(lhs,rhs);

        public static bit neq_g8u(byte lhs, byte rhs)
            => gmath.neq(lhs,rhs);

        public static bit neq_d16i(short lhs, short rhs)
            => math.neq(lhs,rhs);

        public static bit neq_g16i(short lhs, short rhs)
            => gmath.neq(lhs,rhs);

        public static bit neq_d16u(ushort lhs, ushort rhs)
            => math.neq(lhs,rhs);

        public static bit neq_g16u(ushort lhs, ushort rhs)
            => gmath.neq(lhs,rhs);

        public static bit neq_d32i(int lhs, int rhs)
            => math.neq(lhs,rhs);

        public static bit neq_g32i(int lhs, int rhs)
            => gmath.neq(lhs,rhs);

        public static bit neq_d32u(uint lhs, uint rhs)
            => math.neq(lhs,rhs);

        public static bit neq_g32u(uint lhs, uint rhs)
            => gmath.neq(lhs,rhs);

        public static bit neq_d64i(long lhs, long rhs)
            => math.neq(lhs,rhs);

        public static bit neq_g64i(long lhs, long rhs)
            => gmath.neq(lhs,rhs);

        public static bit neq_d64u(ulong lhs, ulong rhs)
            => math.neq(lhs,rhs);

        public static bit neq_g64u(ulong lhs, ulong rhs)
            => gmath.neq(lhs,rhs);

        public static bit neq_d32f(float lhs, float rhs)
            => fmath.neq(lhs,rhs);

        public static bit neq_g32f(float lhs, float rhs)
            => gfp.neq(lhs,rhs);

        public static bit neq_d64f(double lhs, double rhs)
            => fmath.neq(lhs,rhs);
        
        public static bit neq_g64f(double lhs, double rhs)
            => gfp.neq(lhs,rhs);
 
    }

}