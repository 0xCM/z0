//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct core
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint copy<T>(in MemoryCells<T> src, uint offset, uint cells, Span<T> dst)
            where T : unmanaged
        {
            var j=0u;
            var max = min(offset + cells, dst.Length);
            for(var i=offset; i<max; i++)
                seek(dst,j++) = skip(src.View, i);
            return j;
        }
    }
}