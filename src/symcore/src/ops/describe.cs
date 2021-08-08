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

    partial struct Symbols
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void describe<T>(Symbols<T> src, Span<TextBlock> dst)
            where T : unmanaged
        {
            var count = min(src.Length,dst.Length);
            var view = src.View;
            for(var i=0u; i<count; i++)
                seek(dst,i) = src[i].Description;
        }
    }
}