//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        [Op]
        public static void materialize(ReadOnlySpan<SegRef> src, Span<byte> dst, byte? delimiter = null)
        {
            var m = src.Length;
            var n = dst.Length;
            var o = 0u;
            var d = delimiter ?? 0;
            for(var i=0u; i<m; i++)
            {
                var c = skip(src,i).Edit;
                var p = c.Length;

                for(var j=0u; j<p && o<n; j++, o++)
                    seek(dst,o) = skip(c,j);

                if(delimiter != null)
                    seek(dst, ++o) = d;
            }
        }
    }
}