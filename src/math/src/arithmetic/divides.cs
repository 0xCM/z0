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
        [MethodImpl(Inline), Divides]
        public static bool divides(sbyte a, sbyte b)
            => b % a == 0;

        [MethodImpl(Inline), Divides]
        public static bool divides(byte a, byte b)
            => b % a == 0;

        [MethodImpl(Inline), Divides]
        public static bool divides(short a, short b)
            => b % a == 0;

        [MethodImpl(Inline), Divides]
        public static bool divides(ushort a, ushort b)
            => b % a == 0;

        [MethodImpl(Inline), Divides]
        public static bool divides(int a, int b)
            => b % a == 0;

        [MethodImpl(Inline), Divides]
        public static bool divides(uint a, uint b)
            => b % a == 0;

        [MethodImpl(Inline), Divides]
        public static bool divides(long a, long b)
            => b % a == 0;

        [MethodImpl(Inline), Divides]
        public static bool divides(ulong a, ulong b)
            => b % a == 0;
    }
}