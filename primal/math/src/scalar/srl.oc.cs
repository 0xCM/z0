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
        public static sbyte srl_d8i(sbyte lhs, int offset)
            => math.srl(lhs,offset);

        public static sbyte srl_g8i(sbyte lhs, int offset)
            => gmath.srl(lhs,offset);

        public static byte srl_d8u(byte lhs, int offset)
            => math.srl(lhs,offset);

        public static byte srl_g8u(byte lhs, int offset)
            => gmath.srl(lhs,offset);

        public static short srl_d16i(short lhs, int offset)
            => math.srl(lhs,offset);

        public static short srl_g16i(short lhs, int offset)
            => gmath.srl(lhs,offset);

        public static ushort srl_d16u(ushort lhs, int offset)
            => math.srl(lhs,offset);

        public static ushort srl_g16u(ushort lhs, int offset)
            => gmath.srl(lhs,offset);

        public static int srl_d32i(int lhs, int offset)
            => math.srl(lhs,offset);

        public static int srl_g32i(int lhs, int offset)
            => gmath.srl(lhs,offset);

        public static uint srl_d32u(uint lhs, int offset)
            => math.srl(lhs,offset);

        public static uint srl_g32u(uint lhs, int offset)
            => gmath.srl(lhs,offset);

        public static long srl_d64i(long lhs, int offset)
            => math.srl(lhs,offset);

        public static long srl_g64i(long lhs, int offset)
            => gmath.srl(lhs,offset);

        public static ulong srl_d64u(ulong lhs, int offset)
            => math.srl(lhs,offset);

        public static ulong srl_g64u(ulong lhs, int offset)
            => gmath.srl(lhs,offset);

    }

}