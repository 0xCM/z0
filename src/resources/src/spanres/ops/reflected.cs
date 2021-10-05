//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct SpanRes
    {
        public static ReadOnlySpan<ReflectedByteSpan> reflected(Type[] src)
            => ClrModels.bytespans(src);
    }
}