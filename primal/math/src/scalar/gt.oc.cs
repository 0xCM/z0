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
        public static bool gt_d8i(sbyte lhs, sbyte rhs)
            => math.gt(lhs,rhs);

        public static bool gt_g8i(sbyte lhs, sbyte rhs)
            => gmath.gt(lhs,rhs);

        public static bool gt_d8u(byte lhs, byte rhs)
            => math.gt(lhs,rhs);

        public static bool gt_g8u(byte lhs, byte rhs)
            => gmath.gt(lhs,rhs);

        public static bool gt_d16i(short lhs, short rhs)
            => math.gt(lhs,rhs);

        public static bool gt_g16i(short lhs, short rhs)
            => gmath.gt(lhs,rhs);

        public static bool gt_d16u(ushort lhs, ushort rhs)
            => math.gt(lhs,rhs);

        public static bool gt_g16u(ushort lhs, ushort rhs)
            => gmath.gt(lhs,rhs);

        public static bool gt_d32i(int lhs, int rhs)
            => math.gt(lhs,rhs);

        public static bool gt_g32i(int lhs, int rhs)
            => gmath.gt(lhs,rhs);

        public static bool gt_d32u(uint lhs, uint rhs)
            => math.gt(lhs,rhs);

        public static bool gt_g32u(uint lhs, uint rhs)
            => gmath.gt(lhs,rhs);

        public static bool gt_d64i(long lhs, long rhs)
            => math.gt(lhs,rhs);

        public static bool gt_g64i(long lhs, long rhs)
            => gmath.gt(lhs,rhs);

        public static bool gt_d64u(ulong lhs, ulong rhs)
            => math.gt(lhs,rhs);

        public static bool gt_g64u(ulong lhs, ulong rhs)
            => gmath.gt(lhs,rhs);

        public static bool gt_d32f(float lhs, float rhs)
            => fmath.gt(lhs,rhs);

        public static bool gt_g32f(float lhs, float rhs)
            => gfp.gt(lhs,rhs);

        public static bool gt_d64f(double lhs, double rhs)
            => fmath.gt(lhs,rhs);
        
        public static bool gt_g64f(double lhs, double rhs)
            => gfp.gt(lhs,rhs);
 
         public static bool gteq_d8i(sbyte lhs, sbyte rhs)
            => math.gteq(lhs,rhs);

        public static bool gteq_g8i(sbyte lhs, sbyte rhs)
            => gmath.gteq(lhs,rhs);

        public static bool gteq_d8u(byte lhs, byte rhs)
            => math.gteq(lhs,rhs);

        public static bool gteq_g8u(byte lhs, byte rhs)
            => gmath.gteq(lhs,rhs);

        public static bool gteq_d16i(short lhs, short rhs)
            => math.gteq(lhs,rhs);

        public static bool gteq_g16i(short lhs, short rhs)
            => gmath.gteq(lhs,rhs);

        public static bool gteq_d16u(ushort lhs, ushort rhs)
            => math.gteq(lhs,rhs);

        public static bool gteq_g16u(ushort lhs, ushort rhs)
            => gmath.gteq(lhs,rhs);

        public static bool gteq_d32i(int lhs, int rhs)
            => math.gteq(lhs,rhs);

        public static bool gteq_g32i(int lhs, int rhs)
            => gmath.gteq(lhs,rhs);

        public static bool gteq_d32u(uint lhs, uint rhs)
            => math.gteq(lhs,rhs);

        public static bool gteq_g32u(uint lhs, uint rhs)
            => gmath.gteq(lhs,rhs);

        public static bool gteq_d64i(long lhs, long rhs)
            => math.gteq(lhs,rhs);

        public static bool gteq_g64i(long lhs, long rhs)
            => gmath.gteq(lhs,rhs);

        public static bool gteq_d64u(ulong lhs, ulong rhs)
            => math.gteq(lhs,rhs);

        public static bool gteq_g64u(ulong lhs, ulong rhs)
            => gmath.gteq(lhs,rhs);

        public static bool gteq_d32f(float lhs, float rhs)
            => fmath.gteq(lhs,rhs);

        public static bool gteq_g32f(float lhs, float rhs)
            => gfp.gteq(lhs,rhs);

        public static bool gteq_d64f(double lhs, double rhs)
            => fmath.gteq(lhs,rhs);
        
        public static bool gteq_g64f(double lhs, double rhs)
            => gfp.gteq(lhs,rhs);
 
    }

}