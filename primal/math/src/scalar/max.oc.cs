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
        public static sbyte max_d8i(sbyte lhs, sbyte rhs)
            => math.max(lhs,rhs);

        public static sbyte max_g8i(sbyte lhs, sbyte rhs)
            => gmath.max(lhs,rhs);

        public static byte max_d8u(byte lhs, byte rhs)
            => math.max(lhs,rhs);

        public static byte max_g8u(byte lhs, byte rhs)
            => gmath.max(lhs,rhs);

        public static short max_d16i(short lhs, short rhs)
            => math.max(lhs,rhs);

        public static short max_g16i(short lhs, short rhs)
            => gmath.max(lhs,rhs);

        public static ushort max_d16u(ushort lhs, ushort rhs)
            => math.max(lhs,rhs);

        public static ushort max_g16u(ushort lhs, ushort rhs)
            => gmath.max(lhs,rhs);

        public static int max_d32i(int lhs, int rhs)
            => math.max(lhs,rhs);

        public static int max_g32i(int lhs, int rhs)
            => gmath.max(lhs,rhs);

        public static uint max_d32u(uint lhs, uint rhs)
            => math.max(lhs,rhs);

        public static uint max_g32u(uint lhs, uint rhs)
            => gmath.max(lhs,rhs);

        public static long max_d64i(long lhs, long rhs)
            => math.max(lhs,rhs);

        public static long max_g64i(long lhs, long rhs)
            => gmath.max(lhs,rhs);

        public static ulong max_d64u(ulong lhs, ulong rhs)
            => math.max(lhs,rhs);

        public static ulong max_g64u(ulong lhs, ulong rhs)
            => gmath.max(lhs,rhs);

    }

}