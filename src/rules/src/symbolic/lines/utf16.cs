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

    partial struct Lines
    {
        [MethodImpl(Inline), Op]
        public static Utf16Line utf16(ReadOnlySpan<char> src, uint number, uint offset, uint chars)
            => new Utf16Line(number, offset, slice(src, offset, chars));

        [MethodImpl(Inline), Op]
        public static Utf16Line utf16(ReadOnlySpan<byte> src, uint number, uint offset, uint chars)
            => new Utf16Line(number, 0, slice(recover<char>(src), offset, chars));
    }
}