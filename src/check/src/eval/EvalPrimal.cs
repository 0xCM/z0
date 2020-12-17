//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiHost]
    public readonly struct EvalPrimal
    {
        [MethodImpl(Inline), Op]
        public static Outcome<Pair<char>> eq(char a, char b)
            => ((a == b), pair(a,b));

        [MethodImpl(Inline), Op]
        public static Outcome<Pair<string>> eq(string a, string b)
            => ((a == b), pair(a,b));

        [MethodImpl(Inline), Op]
        public static Outcome<Pair<byte>> eq(byte a, byte b)
            => ((a == b), pair(a,b));

        [MethodImpl(Inline), Op]
        public static Outcome<Pair<sbyte>> eq(sbyte a, sbyte b)
            => ((a == b), pair(a,b));

        [MethodImpl(Inline), Op]
        public static Outcome eq(short a, short b)
            => a == b;

        [MethodImpl(Inline), Op]
        public static Outcome eq(ushort a, ushort b)
            => a == b;

        [MethodImpl(Inline), Op]
        public static Outcome eq(int a, int b)
            => a == b;

        [MethodImpl(Inline), Op]
        public static Outcome eq(uint a, uint b)
            => a == b;

        [MethodImpl(Inline), Op]
        public static Outcome eq(long a, long b)
            => a == b;

        [MethodImpl(Inline), Op]
        public static Outcome eq(ulong a, ulong b)
            => a == b;

        [MethodImpl(Inline), Op]
        public static Outcome eq(bool a, bool b)
            => a == b;
    }
}