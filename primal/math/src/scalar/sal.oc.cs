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
        public static sbyte sal_d8i(sbyte lhs, int offset)
            => math.sal(lhs,offset);

        public static sbyte sal_g8i(sbyte lhs, int offset)
            => gmath.sal(lhs,offset);

        public static byte sal_d8u(byte lhs, int offset)
            => math.sal(lhs,offset);

        public static byte sal_g8u(byte lhs, int offset)
            => gmath.sal(lhs,offset);

        public static short sal_d16i(short lhs, int offset)
            => math.sal(lhs,offset);

        public static short sal_g16i(short lhs, int offset)
            => gmath.sal(lhs,offset);

        public static ushort sal_d16u(ushort lhs, int offset)
            => math.sal(lhs,offset);

        public static ushort sal_g16u(ushort lhs, int offset)
            => gmath.sal(lhs,offset);

        public static int sal_d32i(int lhs, int offset)
            => math.sal(lhs,offset);

        public static int sal_g32i(int lhs, int offset)
            => gmath.sal(lhs,offset);

        public static uint sal_d32u(uint lhs, int offset)
            => math.sal(lhs,offset);

        public static uint sal_g32u(uint lhs, int offset)
            => gmath.sal(lhs,offset);

        public static long sal_d64i(long lhs, int offset)
            => math.sal(lhs,offset);

        public static long sal_g64i(long lhs, int offset)
            => gmath.sal(lhs,offset);

        public static ulong sal_d64u(ulong lhs, int offset)
            => math.sal(lhs,offset);

        public static ulong sal_g64u(ulong lhs, int offset)
            => gmath.sal(lhs,offset);

    }

}