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
        public static Span<T> inc<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var count = length(src,dst);
            for(var i = 0; i< count; i++)
                dst[i] = gmath.inc(src[i]);
            return dst;
        }        

        /// <summary>
        /// Increments each value in the source in-place
        /// </summary>
        /// <param name="src">The source values</param>
        [MethodImpl(Inline)]
        public static Span<T> inc<T>(Span<T> src)
            where T : unmanaged
                => inc(src.ReadOnly(), src);
    }
}