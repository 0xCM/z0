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

    partial class BitSpans
    {
        [MethodImpl(Inline), Op]
        public static Span<byte> extract(in BitSpan src, uint offset, uint count)
            => recover<bit,byte>(memory.slice(src.Storage, offset, count));
    }
}