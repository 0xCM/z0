//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;
    using static Typed;

    partial struct SpanRes
    {
        [MethodImpl(Inline), Op]
        public static ByteSize size(ReadOnlySpan<ByteSpanSpec> src)
        {
            var size = ByteSize.Zero;
            var count = src.Length;
            for(var i=0; i<count; i++)
                size += skip(src,i).DataSize;
            return size;
        }
    }
}