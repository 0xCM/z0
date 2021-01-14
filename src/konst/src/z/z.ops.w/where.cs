//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct z
    {
        /// <summary>
        /// Allocates and populates a new array by filtering the source array with a specified predicate
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The array element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] where<T>(ReadOnlySpan<T> src, Func<T,bool> f)
        {
            var length = src.Length;
            var dst = memory.span<T>(length);
            var count = 0u;
            for(var i=0u; i<length; i++)
            {
                ref readonly var test = ref skip(src,i);
                if(f(test))
                    seek(dst, count++) = test;
            }
            return array(dst.Slice(0, (int)count));
        }
    }
}