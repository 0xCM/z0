//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class Spans
    {
        /// <summary>
        /// Determines whether all of the elements of a source span satisfy a supplied predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Closures(Closure), Op]
        public static bool all<T>(ReadOnlySpan<T> src, Func<T,bool> f)
             where T : unmanaged
        {
            for(var i=0; i<src.Length; i++)
                if(!f(skip(src,i)))
                    return false;
            return true;
        }
    }
}