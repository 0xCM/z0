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

    partial class gmoc
    {
        public static bit lt_d8i(sbyte lhs, sbyte rhs)
            => math.lt(lhs,rhs);

        public static bit lt_g8i(sbyte lhs, sbyte rhs)
            => gmath.lt(lhs,rhs);

        public static bit lt_d8u(byte lhs, byte rhs)
            => math.lt(lhs,rhs);

        public static bit lt_g8u(byte lhs, byte rhs)
            => gmath.lt(lhs,rhs);

        public static bit lt_d16i(short lhs, short rhs)
            => math.lt(lhs,rhs);

        public static bit lt_g16i(short lhs, short rhs)
            => gmath.lt(lhs,rhs);

        public static bit lt_d16u(ushort lhs, ushort rhs)
            => math.lt(lhs,rhs);

        public static bit lt_g16u(ushort lhs, ushort rhs)
            => gmath.lt(lhs,rhs);

        public static bit lt_d32i(int lhs, int rhs)
            => math.lt(lhs,rhs);

        public static bit lt_g32i(int lhs, int rhs)
            => gmath.lt(lhs,rhs);

        public static bit lt_d32u(uint lhs, uint rhs)
            => math.lt(lhs,rhs);

        public static bit lt_g32u(uint lhs, uint rhs)
            => gmath.lt(lhs,rhs);

        public static bit lt_d64i(long lhs, long rhs)
            => math.lt(lhs,rhs);

        public static bit lt_g64i(long lhs, long rhs)
            => gmath.lt(lhs,rhs);

        public static bit lt_d64u(ulong lhs, ulong rhs)
            => math.lt(lhs,rhs);

        public static bit lt_g64u(ulong lhs, ulong rhs)
            => gmath.lt(lhs,rhs);

        public static bool lt_d32f(float lhs, float rhs)
            => fmath.lt(lhs,rhs);

        public static bool lt_g32f(float lhs, float rhs)
            => gfp.lt(lhs,rhs);

        public static bool lt_d64f(double lhs, double rhs)
            => fmath.lt(lhs,rhs);
        
        public static bool lt_g64f(double lhs, double rhs)
            => gfp.lt(lhs,rhs);
 
        public static bit lteq_d8i(sbyte lhs, sbyte rhs)
            => math.lteq(lhs,rhs);

        public static bit lteq_g8i(sbyte lhs, sbyte rhs)
            => gmath.lteq(lhs,rhs);

        public static bit lteq_d8u(byte lhs, byte rhs)
            => math.lteq(lhs,rhs);

        public static bit lteq_g8u(byte lhs, byte rhs)
            => gmath.lteq(lhs,rhs);

        public static bit lteq_d16i(short lhs, short rhs)
            => math.lteq(lhs,rhs);

        public static bit lteq_g16i(short lhs, short rhs)
            => gmath.lteq(lhs,rhs);

        public static bit lteq_d16u(ushort lhs, ushort rhs)
            => math.lteq(lhs,rhs);

        public static bit lteq_g16u(ushort lhs, ushort rhs)
            => gmath.lteq(lhs,rhs);

        public static bit lteq_d32i(int lhs, int rhs)
            => math.lteq(lhs,rhs);

        public static bit lteq_g32i(int lhs, int rhs)
            => gmath.lteq(lhs,rhs);

        public static bit lteq_d32u(uint lhs, uint rhs)
            => math.lteq(lhs,rhs);

        public static bit lteq_g32u(uint lhs, uint rhs)
            => gmath.lteq(lhs,rhs);

        public static bit lteq_d64i(long lhs, long rhs)
            => math.lteq(lhs,rhs);

        public static bit lteq_g64i(long lhs, long rhs)
            => gmath.lteq(lhs,rhs);

        public static bit lteq_d64u(ulong lhs, ulong rhs)
            => math.lteq(lhs,rhs);

        public static bit lteq_g64u(ulong lhs, ulong rhs)
            => gmath.lteq(lhs,rhs);
 

       public static bool lteq_d32f(float lhs, float rhs)
            => fmath.lteq(lhs,rhs);

        public static bool lteq_g32f(float lhs, float rhs)
            => gfp.lteq(lhs,rhs);

        public static bool lteq_d64f(double lhs, double rhs)
            => fmath.lteq(lhs,rhs);
        
        public static bool lteq_g64f(double lhs, double rhs)
            => gfp.lteq(lhs,rhs);
 
    }

}