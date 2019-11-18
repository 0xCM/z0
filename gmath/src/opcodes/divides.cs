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
        public static bool divides_d8i(sbyte lhs, sbyte rhs)
            => math.divides(lhs,rhs);

        public static bool divides_g8i(sbyte lhs, sbyte rhs)
            => gmath.divides(lhs,rhs);

        public static bool divides_d8u(byte lhs, byte rhs)
            => math.divides(lhs,rhs);

        public static bool divides_g8u(byte lhs, byte rhs)
            => gmath.divides(lhs,rhs);

        public static bool divides_d16i(short lhs, short rhs)
            => math.divides(lhs,rhs);

        public static bool divides_g16i(short lhs, short rhs)
            => gmath.divides(lhs,rhs);

        public static bool divides_d16u(ushort lhs, ushort rhs)
            => math.divides(lhs,rhs);

        public static bool divides_g16u(ushort lhs, ushort rhs)
            => gmath.divides(lhs,rhs);

        public static bool divides_d32i(int lhs, int rhs)
            => math.divides(lhs,rhs);

        public static bool divides_g32i(int lhs, int rhs)
            => gmath.divides(lhs,rhs);

        public static bool divides_d32u(uint lhs, uint rhs)
            => math.divides(lhs,rhs);

        public static bool divides_g32u(uint lhs, uint rhs)
            => gmath.divides(lhs,rhs);

        public static bool divides_d64i(long lhs, long rhs)
            => math.divides(lhs,rhs);

        public static bool divides_g64i(long lhs, long rhs)
            => gmath.divides(lhs,rhs);

        public static bool divides_d64u(ulong lhs, ulong rhs)
            => math.divides(lhs,rhs);

        public static bool divides_g64u(ulong lhs, ulong rhs)
            => gmath.divides(lhs,rhs);

        public static bool divides_d32f(float lhs, float rhs)
            => fmath.divides(lhs,rhs);

        public static bool divides_g32f(float lhs, float rhs)
            => gfp.divides(lhs,rhs);

        public static bool divides_d64f(double lhs, double rhs)
            => fmath.divides(lhs,rhs);
        
        public static bool divides_g64f(double lhs, double rhs)
            => gfp.divides(lhs,rhs);
 

    }

}