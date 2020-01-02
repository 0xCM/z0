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
        public static Span<T> negate<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var count = length(src,dst);
            for(var i = 0; i< count; i++)
                dst[i] = gmath.negate(src[i]);
            return dst;
        }

        /// <summary>
        /// Applies the negate operator to each source element in-place
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> negate<T>(Span<T> src)
            where T : unmanaged
                => negate(src,src);

        public static Span<T> negate<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => negate(src, span<T>(src.Length));
    }
}