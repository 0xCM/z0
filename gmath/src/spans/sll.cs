//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        public static Span<T> sll<T>(ReadOnlySpan<T> src, int shift, Span<T> dst)
            where T : unmanaged
        {            
            for(var i=0; i<src.Length; i++)
                dst[i] = gmath.sll(src[i], shift);
            return dst;
        }

        public static Span<T> sll<T>(ReadOnlySpan<T> src, int shift)
            where T : unmanaged
                => sll(src, shift, span<T>(src.Length));
    }
}