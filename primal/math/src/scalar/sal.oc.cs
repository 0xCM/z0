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
        public static sbyte sal_8i(sbyte lhs, int offset)
            => math.sal(lhs,offset);

        public static sbyte sal_g8i(sbyte lhs, int offset)
            => gmath.sal(lhs,offset);

        public static byte sal_8u(byte lhs, int offset)
            => math.sal(lhs,offset);

        public static byte sal_g8u(byte lhs, int offset)
            => gmath.sal(lhs,offset);

        public static short sal_16i(short lhs, int offset)
            => math.sal(lhs,offset);

        public static short sal_g16i(short lhs, int offset)
            => gmath.sal(lhs,offset);

        public static ushort sal_16u(ushort lhs, int offset)
            => math.sal(lhs,offset);

        public static ushort sal_g16u(ushort lhs, int offset)
            => gmath.sal(lhs,offset);

        public static int sal_32i(int lhs, int offset)
            => math.sal(lhs,offset);

        public static int sal_g32i(int lhs, int offset)
            => gmath.sal(lhs,offset);

        public static uint sal_32u(uint lhs, int offset)
            => math.sal(lhs,offset);

        public static uint sal_g32u(uint lhs, int offset)
            => gmath.sal(lhs,offset);

        public static long sal_64i(long lhs, int offset)
            => math.sal(lhs,offset);

        public static long sal_g64i(long lhs, int offset)
            => gmath.sal(lhs,offset);

        public static ulong sal_64u(ulong lhs, int offset)
            => math.sal(lhs,offset);

        public static ulong sal_g64u(ulong lhs, int offset)
            => gmath.sal(lhs,offset);

    }

}