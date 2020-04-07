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
        [MethodImpl(Inline), Op]
        public static bit within(sbyte a, sbyte b, sbyte tolerance)
            => dist(a,b) <= (uint)tolerance;

        [MethodImpl(Inline), Op]
        public static bit within(byte a, byte b, byte tolerance)
            => dist(a,b) <= tolerance;

        [MethodImpl(Inline), Op]
        public static bit within(short a, short b, short tolerance)
            => dist(a,b) <= (uint)tolerance;

        [MethodImpl(Inline), Op]
        public static bit within(ushort a, ushort b, ushort tolerance)
            => dist(a,b) <= tolerance;

        [MethodImpl(Inline), Op]
        public static bit within(int a, int b, int tolerance)
            => dist(a,b) <= (uint)tolerance;

        [MethodImpl(Inline), Op]
        public static bit within(uint a, uint b, uint tolerance)
            => dist(a,b) <= tolerance;

        [MethodImpl(Inline), Op]
        public static bit within(long a, long b, long tolerance)
            => dist(a,b) <= (ulong)tolerance;

        [MethodImpl(Inline), Op]
        public static bit within(ulong a, ulong b, ulong tolerance)
            => dist(a,b) <= tolerance;
    }

}