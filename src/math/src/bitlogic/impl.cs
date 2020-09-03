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
        [MethodImpl(Inline)]
        public static sbyte impl(sbyte a, sbyte b)
            => (sbyte)((int)a | ~(int)b);

        [MethodImpl(Inline)]
        public static byte impl(byte a, byte b)
            => (byte)(a | ~b);

        [MethodImpl(Inline)]
        public static short impl(short a, short b)
            => (short)((int)a | ~(int)b);

        [MethodImpl(Inline)]
        public static ushort impl(ushort a, ushort b)
            => (ushort)(a | ~b);

        [MethodImpl(Inline)]
        public static int impl(int a, int b)
            => a | ~ b;

        [MethodImpl(Inline)]
        public static uint impl(uint a, uint b)
            => a | ~b;

        [MethodImpl(Inline)]
        public static long impl(long a, long b)
            => a | ~ b;

        [MethodImpl(Inline)]
        public static ulong impl(ulong a, ulong b)
            => a | ~b;
    }
}