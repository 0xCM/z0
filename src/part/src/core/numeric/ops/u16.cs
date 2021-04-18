//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Numeric
    {
        [MethodImpl(Inline), Op]
        public static ushort u16(ReadOnlySpan<byte> src)
            => first16u(src);

        [MethodImpl(Inline), Op]
        public static ushort u16(ReadOnlySpan<byte> src, uint offset)
            => skip16(src, offset);
    }
}