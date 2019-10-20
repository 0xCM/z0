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

    partial class bvoc
    {
        public static sbyte segment_d8i(sbyte src, int i0, int i1)
            => Bits.segment(src, i0, i1);

        public static sbyte segment_g8i(sbyte src, int i0, int i1)
            => gbits.segment(src, i0, i1);

        public static byte segment_d8u(byte src, int i0, int i1)
            => Bits.segment(src, i0, i1);

        public static byte segment_g8u(byte src, int i0, int i1)
            => gbits.segment(src, i0, i1);

        public static short segment_d16i(short src, int i0, int i1)
            => Bits.segment(src, i0, i1);

        public static short segment_g16i(short src, int i0, int i1)
            => gbits.segment(src, i0, i1);

        public static ushort segment_d16u(ushort src, int i0, int i1)
            => Bits.segment(src, i0, i1);

        public static ushort segment_g16u(ushort src, int i0, int i1)
            => gbits.segment(src, i0, i1);

        public static int segment_d32i(int src, int i0, int i1)
            => Bits.segment(src, i0, i1);

        public static int segment_g32i(int src, int i0, int i1)
            => gbits.segment(src, i0, i1);

        public static uint segment_d32u(uint src, int i0, int i1)
            => Bits.segment(src, i0, i1);

        public static uint segment_g32u(uint src, int i0, int i1)
            => gbits.segment(src, i0, i1);

        public static long segment_d64i(long src, int i0, int i1)
            => Bits.segment(src, i0, i1);

        public static long segment_g64i(long src, int i0, int i1)
            => gbits.segment(src, i0, i1);

        public static ulong segment_d64u(ulong src, int i0, int i1)
            => Bits.segment(src, i0, i1);

        public static ulong segment_g64u(ulong src, int i0, int i1)
            => gbits.segment(src, i0, i1);

        public static float segment_g32f(float src, int i0, int i1)
            => gbits.segment(src, i0, i1);

        public static double segment_g64f(double src, int i0, int i1)
            => gbits.segment(src, i0, i1);

    }

}