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
    using static Control;
    
    [ApiHost]
    public readonly struct VCopy : IApiHost<VCopy>
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void vcopy<T>(W256 w, ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var seglen = Vector256<T>.Count;            
            var blocks = length(src,dst)/seglen;
            for(var i=0; i<blocks; i++)
            {
                var offset = i*seglen;
                var vSrc = Vectors.vload(w,skip(src, offset));
                Vectors.vstore(vSrc,ref seek(dst,offset));
            }            
        }
    }
}