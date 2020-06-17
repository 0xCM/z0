//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    partial class Permute
    {
        /// <summary>
        /// Shuffles span content as determined by a permutation
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="p">The permutation to apply</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Span<T> apply<T>(Perm p, ReadOnlySpan<T> src, in Span<T> dst)
        {            
            for(var i=0; i<p.Length; i++)
                seek(dst,i) = skip(src,p[i]);                
            return ref dst;
        }

        public static Span<T> apply<T>(Perm p, ReadOnlySpan<T> src)
            => apply(p,src,new T[src.Length]);
    }
}