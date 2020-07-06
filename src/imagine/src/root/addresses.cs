//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        [MethodImpl(Inline), Op]
        public static void addresses(ReadOnlySpan<string> src, Span<MemoryAddress> dst)
        {
            ref readonly var r0 = ref head(src);
            for(var i=0; i<src.Length; i++)
                seek(dst,i) = address(skip(r0,i));
        }
    }
}