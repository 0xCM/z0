//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Typed;
    using static As;
    using static Root;

    partial struct V0
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void vcopy<T>(W256 w, ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var seglen = vcount<T>(w);
            var blocks = length(src,dst)/seglen;
            for(var i=0; i<blocks; i++)
            {
                var offset = i*seglen;
                var vSrc = vload(w, skip(src, offset));
                vsave(vSrc, ref seek(dst,offset));
            }            
        }        

    }
}