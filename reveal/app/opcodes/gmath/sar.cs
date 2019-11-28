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
        public static sbyte sar_d8i(sbyte lhs, int offset)
            => math.sar(lhs,offset);

        public static sbyte sar_g8i(sbyte lhs, int offset)
            => gmath.sar(lhs,offset);

        public static byte sar_d8u(byte lhs, int offset)
            => math.sar(lhs,offset);

        public static byte sar_g8u(byte lhs, int offset)
            => gmath.sar(lhs,offset);

        public static short sar_d16i(short lhs, int offset)
            => math.sar(lhs,offset);

        public static short sar_g16i(short lhs, int offset)
            => gmath.sar(lhs,offset);

        public static ushort sar_d16u(ushort lhs, int offset)
            => math.sar(lhs,offset);

        public static ushort sar_g16u(ushort lhs, int offset)
            => gmath.sar(lhs,offset);

        public static int sar_d32i(int lhs, int offset)
            => math.sar(lhs,offset);

        public static int sar_g32i(int lhs, int offset)
            => gmath.sar(lhs,offset);

        public static uint sar_d32u(uint lhs, int offset)
            => math.sar(lhs,offset);

        public static uint sar_g32u(uint lhs, int offset)
            => gmath.sar(lhs,offset);

        public static long sar_d64i(long lhs, int offset)
            => math.sar(lhs,offset);

        public static long sar_g64i(long lhs, int offset)
            => gmath.sar(lhs,offset);

        public static ulong sar_d64u(ulong lhs, int offset)
            => math.sar(lhs,offset);

        public static ulong sar_g64u(ulong lhs, int offset)
            => gmath.sar(lhs,offset);
    }

}