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

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint copy<T>(in Vec<T> src, in Vec<T> dst)
            => copy(@readonly(src.Storage), span(dst.Storage));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint copy<T>(in SpanVec<T> src, in SpanVec<T> dst)
            => copy(@readonly(src.Storage), dst.Storage);

        [MethodImpl(Inline), Op, Closures(Closure)]
        static uint copy<T>(ReadOnlySpan<T> src, Span<T> dst)
        {
            var length = min(src.Length,dst.Length);
            for(var i=0; i<length; i++)
                seek(dst,i) = skip(src,i);
            return (uint)length;
        }
    }
}