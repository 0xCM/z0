//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    partial struct memory
    {
        /// <summary>
        /// Copies a source list to a target array
        /// </summary>
        /// <param name="src">The list containing the elements to copy</param>
        /// <param name="dst">The array that will receive the copied elements</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static int copy<T>(IReadOnlyList<T> src, T[] dst)
        {
            var count = zfunc.min(src?.Count ?? 0, dst?.Length ?? 0);
            if(count != 0)
            {
                ref var target = ref first(dst);
                for(var i=0; i<count; i++)
                    seek(target,i) = src[i];
            }
            return count;
        }

        /// <summary>
        /// Copies a source array to a target array
        /// </summary>
        /// <param name="src">The list containing the elements to copy</param>
        /// <param name="dst">The array that will receive the copied elements</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static int copy<T>(T[] src, T[] dst)
        {
            var count = zfunc.min(src?.Length ?? 0, dst?.Length ?? 0);
            if(count != 0)
            {
                ref var target = ref first(dst);
                var source = @readonly(src);
                for(var i=0; i<count; i++)
                    seek(target,i) = skip(source, i);
            }
            return count;
        }
    }
}