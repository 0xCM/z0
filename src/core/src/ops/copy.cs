//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct core
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint copy<T>(in MemoryCells<T> src, uint offset, uint cells, Span<T> dst)
            where T : unmanaged
        {
            var j=0u;
            var max = min(offset + cells, dst.Length);
            for(var i=offset; i<max; i++)
                seek(dst,j++) = skip(src.View, i);
            return j;
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
            var count = min(src?.Length ?? 0, dst?.Length ?? 0);
            if(count != 0)
            {
                ref var target = ref first(dst);
                ref readonly var source = ref first(src);
                for(var i=0; i<count; i++)
                    seek(target,i) = skip(source, i);
            }
            return count;
        }

    }
}