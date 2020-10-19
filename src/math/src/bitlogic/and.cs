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
        public static sbyte and(sbyte a, sbyte b)
            => (sbyte)(a & b);

        [MethodImpl(Inline)]
        public static byte and(byte a, byte b)
            => (byte)(a & b);

        [MethodImpl(Inline)]
        public static short and(short a, short b)
            => (short)(a & b);

        [MethodImpl(Inline)]
        public static ushort and(ushort a, ushort b)
            => (ushort)(a & b);

        [MethodImpl(Inline)]
        public static int and(int a, int b)
            => a & b;

        [MethodImpl(Inline)]
        public static uint and(uint a, uint b)
            => a & b;

        [MethodImpl(Inline)]
        public static long and(long a, long b)
            => a & b;

        [MethodImpl(Inline)]
        public static ulong and(ulong a, ulong b)
            => a & b;
   }
}