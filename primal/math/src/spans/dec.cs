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
        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = gmath.dec(src[i]);
            return dst;
        }        

        /// <summary>
        /// Decrements each value in the source in-place
        /// </summary>
        /// <param name="src">The source values</param>
        [MethodImpl(Inline)]
        public static Span<T> dec<T>(Span<T> src)
            where T : unmanaged
                => dec(src.ReadOnly(), src);
    }
}