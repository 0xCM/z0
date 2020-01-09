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
        public static sbyte srl_d8i(sbyte lhs, byte offset)
            => math.srl(lhs,offset);

        public static sbyte srl_g8i(sbyte lhs, byte offset)
            => gmath.srl(lhs,offset);

        public static byte srl_d8u(byte lhs, byte offset)
            => math.srl(lhs,offset);

        public static byte srl_g8u(byte lhs, byte offset)
            => gmath.srl(lhs,offset);

        public static short srl_d16i(short lhs, byte offset)
            => math.srl(lhs,offset);

        public static short srl_g16i(short lhs, byte offset)
            => gmath.srl(lhs,offset);

        public static ushort srl_d16u(ushort lhs, byte offset)
            => math.srl(lhs,offset);

        public static ushort srl_g16u(ushort lhs, byte offset)
            => gmath.srl(lhs,offset);

        public static int srl_d32i(int lhs, byte offset)
            => math.srl(lhs,offset);

        public static int srl_g32i(int lhs, byte offset)
            => gmath.srl(lhs,offset);

        public static uint srl_d32u(uint lhs, byte offset)
            => math.srl(lhs,offset);

        public static uint srl_g32u(uint lhs, byte offset)
            => gmath.srl(lhs,offset);

        public static long srl_d64i(long lhs, byte offset)
            => math.srl(lhs,offset);

        public static long srl_g64i(long lhs, byte offset)
            => gmath.srl(lhs,offset);

        public static ulong srl_d64u(ulong lhs, byte offset)
            => math.srl(lhs,offset);

        public static ulong srl_g64u(ulong lhs, byte offset)
            => gmath.srl(lhs,offset);

    }

}