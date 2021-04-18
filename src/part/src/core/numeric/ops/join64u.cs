//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Numeric
    {
        [MethodImpl(Inline), Op]
        public static ulong join64u(byte a, byte b)
            => (ulong)a | (ulong)b << 8;

        [MethodImpl(Inline), Op]
        public static ulong join64u(byte a, byte b, byte c)
            => (ulong)a | (ulong)b << 8 | (ulong)c << 16;

        [MethodImpl(Inline), Op]
        public static ulong join64u(byte a, byte b, byte c, byte d)
            => (ulong)a | (ulong)b << 8 | (ulong)c << 16 | (ulong)d << 24;

        [MethodImpl(Inline), Op]
        public static ulong join64u(byte a, byte b, byte c, byte d, byte e)
            => (ulong)a | (ulong)b << 8 | (ulong)c << 16 | (ulong)d << 24
             | (ulong)e << 32;

        [MethodImpl(Inline), Op]
        public static ulong join64u(byte a, byte b, byte c, byte d, byte e, byte f)
            => (ulong)a | (ulong)b << 8 | (ulong)c << 16 | (ulong)d << 24
             | (ulong)e << 32 | (ulong)f << 40;

        [MethodImpl(Inline), Op]
        public static ulong join64u(byte a, byte b, byte c, byte d, byte e, byte f, byte g)
            => (ulong)a | (ulong)b << 8 | (ulong)c << 16 | (ulong)d << 24
             | (ulong)e << 32 | (ulong)f << 40 | (ulong)g << 48;

        [MethodImpl(Inline), Op]
        public static ulong join64u(byte a, byte b, byte c, byte d, byte e, byte f, byte g, byte h)
            => (ulong)a | (ulong)b << 8 | (ulong)c << 16 | (ulong)d << 24
             | (ulong)e << 32 | (ulong)f << 40 | (ulong)g << 48 | (ulong)h << 56;
    }
}