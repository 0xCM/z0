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

    partial class Cells
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint copy<T>(in CellBuffer<T> src, uint offset, uint cells, Span<T> dst)
            where T : unmanaged, IDataCell
        {
            var j=0u;
            var max = root.min(offset + cells, dst.Length);
            for(var i=offset; i<max; i++)
                seek(dst,j++) = skip(src.View,i);
            return j;
        }
    }
}