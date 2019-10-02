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
        public static sbyte sar_b8i(sbyte lhs, int offset)
            => math.sar(lhs,offset);

        public static sbyte sar_g8i(sbyte lhs, int offset)
            => gmath.sar(lhs,offset);

        public static byte sar_b8u(byte lhs, int offset)
            => math.sar(lhs,offset);

        public static byte sar_g8u(byte lhs, int offset)
            => gmath.sar(lhs,offset);

        public static short sar_b16i(short lhs, int offset)
            => math.sar(lhs,offset);

        public static short sar_g16i(short lhs, int offset)
            => gmath.sar(lhs,offset);

        public static ushort sar_b16u(ushort lhs, int offset)
            => math.sar(lhs,offset);

        public static ushort sar_g16u(ushort lhs, int offset)
            => gmath.sar(lhs,offset);

        public static int sar_b32i(int lhs, int offset)
            => math.sar(lhs,offset);

        public static int sar_g32i(int lhs, int offset)
            => gmath.sar(lhs,offset);

        public static uint sar_b32u(uint lhs, int offset)
            => math.sar(lhs,offset);

        public static uint sar_g32u(uint lhs, int offset)
            => gmath.sar(lhs,offset);

        public static long sar_b64i(long lhs, int offset)
            => math.sar(lhs,offset);

        public static long sar_g64i(long lhs, int offset)
            => gmath.sar(lhs,offset);

        public static ulong sar_b64u(ulong lhs, int offset)
            => math.sar(lhs,offset);

        public static ulong sar_g64u(ulong lhs, int offset)
            => gmath.sar(lhs,offset);

    }

}