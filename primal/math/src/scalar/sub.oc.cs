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
        public static sbyte sub_d8i(sbyte lhs, sbyte rhs)
            => math.sub(lhs,rhs);

        public static sbyte sub_g8i(sbyte lhs, sbyte rhs)
            => gmath.sub(lhs,rhs);

        public static byte sub_d8u(byte lhs, byte rhs)
            => math.sub(lhs,rhs);

        public static byte sub_g8u(byte lhs, byte rhs)
            => gmath.sub(lhs,rhs);

        public static short sub_d16i(short lhs, short rhs)
            => math.sub(lhs,rhs);

        public static short sub_g16i(short lhs, short rhs)
            => gmath.sub(lhs,rhs);

        public static ushort sub_d16u(ushort lhs, ushort rhs)
            => math.sub(lhs,rhs);

        public static ushort sub_g16u(ushort lhs, ushort rhs)
            => gmath.sub(lhs,rhs);

        public static int sub_d32i(int lhs, int rhs)
            => math.sub(lhs,rhs);

        public static int sub_g32i(int lhs, int rhs)
            => gmath.sub(lhs,rhs);

        public static uint sub_d32u(uint lhs, uint rhs)
            => math.sub(lhs,rhs);

        public static uint sub_g32u(uint lhs, uint rhs)
            => gmath.sub(lhs,rhs);

        public static long sub_d64i(long lhs, long rhs)
            => math.sub(lhs,rhs);

        public static long sub_g64i(long lhs, long rhs)
            => gmath.sub(lhs,rhs);

        public static ulong sub_d64u(ulong lhs, ulong rhs)
            => math.sub(lhs,rhs);

        public static ulong sub_g64u(ulong lhs, ulong rhs)
            => gmath.sub(lhs,rhs);
    }
}