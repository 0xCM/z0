//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;

    partial class boc
    {
        public static sbyte bitrange_d8i(sbyte src, BitPos i0, BitPos i1)
            => Bits.range(src, i0, i1);

        public static sbyte bitrange_g8i(sbyte src, BitPos i0, BitPos i1)
            => gbits.range(src, i0, i1);

        public static byte bitrange_d8u(byte src, BitPos i0, BitPos i1)
            => Bits.range(src, i0, i1);

        public static byte bitrange_g8u(byte src, BitPos i0, BitPos i1)
            => gbits.range(src, i0, i1);

        public static short bitrange_d16i(short src, BitPos i0, BitPos i1)
            => Bits.range(src, i0, i1);

        public static short bitrange_g16i(short src, BitPos i0, BitPos i1)
            => gbits.range(src, i0, i1);

        public static ushort bitrange_d16u(ushort src, BitPos i0, BitPos i1)
            => Bits.range(src, i0, i1);

        public static ushort bitrange_g16u(ushort src, BitPos i0, BitPos i1)
            => gbits.range(src, i0, i1);

        public static int bitrange_d32i(int src, BitPos i0, BitPos i1)
            => Bits.range(src, i0, i1);

        public static int bitrange_g32i(int src, BitPos i0, BitPos i1)
            => gbits.range(src, i0, i1);

        public static uint bitrange_d32u(uint src, BitPos i0, BitPos i1)
            => Bits.range(src, i0, i1);

        public static uint bitrange_g32u(uint src, BitPos i0, BitPos i1)
            => gbits.range(src, i0, i1);

        public static long bitrange_d64i(long src, BitPos i0, BitPos i1)
            => Bits.range(src, i0, i1);

        public static long bitrange_g64i(long src, BitPos i0, BitPos i1)
            => gbits.range(src, i0, i1);

        public static ulong bitrange_d64u(ulong src, BitPos i0, BitPos i1)
            => Bits.range(src, i0, i1);

        public static ulong bitrange_g64u(ulong src, BitPos i0, BitPos i1)
            => gbits.range(src, i0, i1);

        public static float bitrange_g32f(float src, BitPos i0, BitPos i1)
            => gbits.range(src, i0, i1);

        public static double bitrange_g64f(double src, BitPos i0, BitPos i1)
            => gbits.range(src, i0, i1);

    }

}