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
        [MethodImpl(Inline), LtEq]
        public static bool lteq(sbyte a, sbyte b)
            => a <= b;

        [MethodImpl(Inline), LtEq]
        public static bool lteq(byte a, byte b)
            => a <= b;

        [MethodImpl(Inline), LtEq]
        public static bool lteq(short a, short b)
            => a <= b;

        [MethodImpl(Inline), LtEq]
        public static bool lteq(ushort a, ushort b)
            => a <= b;

        [MethodImpl(Inline), LtEq]
        public static bool lteq(int a, int b)
            => a <= b;

        [MethodImpl(Inline), LtEq]
        public static bool lteq(uint a, uint b)
            => a <= b;

        [MethodImpl(Inline), LtEq]
        public static bool lteq(long a, long b)
            => a <= b;

        [MethodImpl(Inline), LtEq]
        public static bool lteq(ulong a, ulong b)
            => a <= b; 
    }
}