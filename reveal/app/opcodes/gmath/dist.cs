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
        public static ulong dist_d8i(sbyte lhs, sbyte rhs)
            => math.dist(lhs,rhs);

        public static ulong dist_g8i(sbyte lhs, sbyte rhs)
            => gmath.dist(lhs,rhs);

        public static ulong dist_d8u(byte lhs, byte rhs)
            => math.dist(lhs,rhs);

        public static ulong dist_g8u(byte lhs, byte rhs)
            => gmath.dist(lhs,rhs);

        public static ulong dist_d16i(short lhs, short rhs)
            => math.dist(lhs,rhs);

        public static ulong dist_g16i(short lhs, short rhs)
            => gmath.dist(lhs,rhs);

        public static ulong dist_d16u(ushort lhs, ushort rhs)
            => math.dist(lhs,rhs);

        public static ulong dist_g16u(ushort lhs, ushort rhs)
            => gmath.dist(lhs,rhs);

        public static ulong dist_d32i(int lhs, int rhs)
            => math.dist(lhs,rhs);

        public static ulong dist_g32i(int lhs, int rhs)
            => gmath.dist(lhs,rhs);

        public static ulong dist_d32u(uint lhs, uint rhs)
            => math.dist(lhs,rhs);

        public static ulong dist_g32u(uint lhs, uint rhs)
            => gmath.dist(lhs,rhs);

        public static ulong dist_d64i(long lhs, long rhs)
            => math.dist(lhs,rhs);

        public static ulong dist_g64i(long lhs, long rhs)
            => gmath.dist(lhs,rhs);

        public static ulong dist_d64u(ulong lhs, ulong rhs)
            => math.dist(lhs,rhs);

        public static ulong dist_g64u(ulong lhs, ulong rhs)
            => gmath.dist(lhs,rhs);

    }

}