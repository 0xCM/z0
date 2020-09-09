//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct PrimalChecks
    {
        [MethodImpl(Inline), Op]
        public static Outcome<Pair<char>> eq(char lhs, char rhs)
            => ((lhs == rhs), pair(lhs,rhs));

        [MethodImpl(Inline), Op]
        public static Outcome<Pair<string>> eq(string lhs, string rhs)
            => ((lhs == rhs), pair(lhs,rhs));

        [MethodImpl(Inline), Op]
        public static Outcome<Pair<byte>> eq(byte lhs, byte rhs)
            => ((lhs == rhs), pair(lhs,rhs));

        [MethodImpl(Inline), Op]
        public static Outcome<Pair<sbyte>> eq(sbyte lhs, sbyte rhs)
            => ((lhs == rhs), pair(lhs,rhs));

        [MethodImpl(Inline), Op]
        public static Outcome eq(short lhs, short rhs)
            => lhs == rhs;

        [MethodImpl(Inline), Op]
        public static Outcome eq(ushort lhs, ushort rhs)
            => lhs == rhs;

        [MethodImpl(Inline), Op]
        public static Outcome eq(int lhs, int rhs)
            => lhs == rhs;

        [MethodImpl(Inline), Op]
        public static Outcome eq(uint lhs, uint rhs)
            => lhs == rhs;

        [MethodImpl(Inline), Op]
        public static Outcome eq(long lhs, long rhs)
            => lhs == rhs;

        [MethodImpl(Inline), Op]
        public static Outcome eq(ulong lhs, ulong rhs)
            => lhs == rhs;

        [MethodImpl(Inline), Op]
        public static Outcome eq(bool lhs, bool rhs)
            => lhs == rhs;
    }
}