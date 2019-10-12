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
        public static Span<T> flip<T>(Span<T> src)
            where T : unmanaged
        {
            for(var i=0; i< src.Length; i++)
                gmath.flip(ref src[i]);
            return src;
        }

        public static Span<T> flip<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< src.Length; i++)
                dst[i] = gmath.flip(src[i]);
            return dst;            
        }
    }
}