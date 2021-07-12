//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Digital
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> bits(N1 n)
            => Bytes.cells<byte>(n2);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> bits(N2 n)
            => Bytes.cells<byte>(n4);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> bits(N3 n)
            => Bytes.cells<byte>(n8);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> bits(N4 n)
            => Bytes.cells<byte>(n16);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> bits(N5 n)
            => Bytes.cells<byte>(n32);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> bits(N6 n)
            => Bytes.cells<byte>(n64);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> bits(N7 n)
            => Bytes.cells<byte>(n128);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> bits(N8 n)
            => Bytes.cells<byte>(n256);
    }
}