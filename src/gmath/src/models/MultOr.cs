//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    readonly struct MultiOr
    {
        [MethodImpl(Inline), Or]
        public static sbyte or(sbyte a, sbyte b, sbyte c)
            => (sbyte)((int)a | (int)b | (int)c);

        [MethodImpl(Inline), Or]
        public static byte or(byte a, byte b, byte c)
            => (byte)((uint)a | (uint)b | (uint)c);

        [MethodImpl(Inline), Or]
        public static short or(short a, short b, short c)
            => (short)((int)a | (int)b | (int)c);

        [MethodImpl(Inline), Or]
        public static ushort or(ushort a, ushort b, ushort c)
            => (ushort)((uint)a | (uint)b | (uint)c);

        [MethodImpl(Inline), Or]
        public static int or(int a, int b, int c)
            => a | b | c;

        [MethodImpl(Inline), Or]
        public static uint or(uint a, uint b, uint c)
            => a | b | c;

        [MethodImpl(Inline), Or]
        public static long or(long a, long b, long c)
            => a | b | c;

        [MethodImpl(Inline), Or]
        public static ulong or(ulong a, ulong b, ulong c)
            => a | b | c;
    }
}