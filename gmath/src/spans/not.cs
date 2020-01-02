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
        public static Span<T> not<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var count = src.Length;
            for(var i=0; i< count; i++)
                dst[i] = gmath.not(src[i]);
            return dst;            
        }

        /// <summary>
        /// Applies the bitwise complement operator to each source element in-place
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> not<T>(Span<T> src)
            where T : unmanaged
                => not(src,src);
        
        /// <summary>
        /// Allocates a new span into which the bitwise complement of each source element is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static Span<T> not<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => not(src, span<T>(src.Length));
    }
}