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
        [MethodImpl(Inline), Eq]
        public static bit eq(sbyte a, sbyte b)
            => a == b;

        [MethodImpl(Inline), Eq]
        public static bit eq(byte a, byte b)
            => a == b;

        [MethodImpl(Inline), Eq]
        public static bit eq(short a, short b)
            => a == b;

        [MethodImpl(Inline), Eq]
        public static bit eq(ushort a, ushort b)
            => a == b;

        [MethodImpl(Inline), Eq]
        public static bit eq(int a, int b)
            => a == b;

        [MethodImpl(Inline), Eq]
        public static bit eq(uint a, uint b)
            => a == b;

        [MethodImpl(Inline), Eq]
        public static bit eq(long a, long b)
            => a == b;

        [MethodImpl(Inline), Eq]
        public static bit eq(ulong a, ulong b)
            => a == b;  
    }
}