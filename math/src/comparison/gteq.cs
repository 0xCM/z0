//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;    
    
    partial class math
    {
        [MethodImpl(Inline), GtEq]
        public static bit gteq(sbyte a, sbyte b)
            => a >= b;

        [MethodImpl(Inline), GtEq]
        public static bit gteq(byte a, byte b)
            => a >= b;

        [MethodImpl(Inline), GtEq]
        public static bit gteq(short a, short b)
            => a >= b;

        [MethodImpl(Inline), GtEq]
        public static bit gteq(ushort a, ushort b)
            => a >= b;

        [MethodImpl(Inline), GtEq]
        public static bit gteq(int a, int b)
            => a >= b;

        [MethodImpl(Inline), GtEq]
        public static bit gteq(uint a, uint b)
            => a >= b;

        [MethodImpl(Inline), GtEq]
        public static bit gteq(long a, long b)
            => a >= b;

        [MethodImpl(Inline), GtEq]
        public static bit gteq(ulong a, ulong b)
            => a >= b;
    }
}