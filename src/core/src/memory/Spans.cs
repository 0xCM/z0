//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct Spans
    {
        [MethodImpl(Inline), Op]
        public static SpanWriter writer(Span<byte> dst)
            => new SpanWriter(dst);
    }
}