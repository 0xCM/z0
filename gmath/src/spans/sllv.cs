//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class mathspan
    {
        [MethodImpl(Inline)]
        public static Span<T> sllv<T>(ReadOnlySpan<T> src, ReadOnlySpan<T> offsets, Span<T> dst)
            where T : unmanaged
        {
            var count = length(src,offsets);
            for(var i=0; i<count; i++)
                dst[i] = gmath.sll(src[i], convert<T,int>(offsets[i]));
            return dst;
        }

        public static Span<T> sllv<T>(ReadOnlySpan<T> src, ReadOnlySpan<T> offsets)
            where T : unmanaged
                => sllv(src, offsets, span<T>(length(src,offsets)));
    }
}