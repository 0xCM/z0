//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Numeric
    {
        [MethodImpl(Inline), Op]
        public static byte read8u(ReadOnlySpan<byte> src)
            => src.Length != 0 ? first(src) : z8;

        [MethodImpl(Inline), Op]
        public static sbyte read8i(ReadOnlySpan<byte> src)
            => @as<sbyte>(read8u(src));

        [MethodImpl(Inline), Op]
        public static ushort read16u(ReadOnlySpan<byte> src)
        {
            var len = src.Length;
            if(len >= 2)
                return first16u(src);
            else if(len > 0)
                return first(src);
            else
                return 0;
        }

        [MethodImpl(Inline), Op]
        public static short read16i(ReadOnlySpan<byte> src)
            => @as<short>(read16u(src));

        [MethodImpl(Inline), Op]
        public static uint read32u(ReadOnlySpan<byte> src)
        {
            var len = src.Length;
            if(len >= 4)
                return first32u(src);
            else
                return read16u(src);
        }

        [MethodImpl(Inline), Op]
        public static int read32i(ReadOnlySpan<byte> src)
            => @as<int>(read32u(src));

        [MethodImpl(Inline), Op]
        public static float read32f(ReadOnlySpan<byte> src)
            => @as<float>(read32u(src));

        [MethodImpl(Inline), Op]
        public static ulong read64u(ReadOnlySpan<byte> src)
        {
            var len = src.Length;
            if(len >= 8)
                return first64u(src);
            else
                return read32u(src);
        }

        [MethodImpl(Inline), Op]
        public static long read64i(ReadOnlySpan<byte> src)
            => @as<long>(read64u(src));

        [MethodImpl(Inline), Op]
        public static double read64f(ReadOnlySpan<byte> src)
            => @as<double>(read64u(src));
    }
}