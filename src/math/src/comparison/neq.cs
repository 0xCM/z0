//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class math
    {
        [MethodImpl(Inline), Neq]
        public static bit neq(sbyte a, sbyte b)
            => a != b;

        [MethodImpl(Inline), Neq]
        public static bit neq(byte a, byte b)
            => a != b;

        [MethodImpl(Inline), Neq]
        public static bit neq(short a, short b)
            => a != b;

        [MethodImpl(Inline), Neq]
        public static bit neq(ushort a, ushort b)
            => a != b;

        [MethodImpl(Inline), Neq]
        public static bit neq(int a, int b)
            => a != b;

        [MethodImpl(Inline), Neq]
        public static bit neq(uint a, uint b)
            => a != b;

        [MethodImpl(Inline), Neq]
        public static bit neq(long a, long b)
            => a != b;

        [MethodImpl(Inline), Neq]
        public static bit neq(ulong a, ulong b)
            => a != b;
    }
}