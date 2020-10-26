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

    partial struct DataLayouts
    {
        /// <summary>
        /// Computes the aggregate width of a <see cref='DataLayout'/> sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        [MethodImpl(Inline), Op]
        public static ulong width(ReadOnlySpan<DataLayout> src)
        {
            var total = 0ul;
            var count = src.Length;
            ref readonly var item = ref first(src);
            for(var i=0; i<count; i++)
                total += width(skip(item,i).Partitions);
            return total;
        }

        /// <summary>
        /// Computes the aggregate width of a <see cref='LayoutPartition'/> sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        [MethodImpl(Inline), Op]
        public static ulong width(ReadOnlySpan<LayoutPartition> src)
        {
            var total = 0ul;
            var count = src.Length;
            ref readonly var item = ref first(src);
            for(var i=0; i<count; i++)
                total += skip(item,i).Width;
            return total;
        }

        /// <summary>
        /// Computes the aggregate width of a <see cref='LayoutPartition{T}'/> sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The partition kind</typeparam>
        [MethodImpl(Inline), Op]
        public static ulong width<T>(ReadOnlySpan<LayoutPartition<T>> src)
            where T : unmanaged
        {
            var total = 0ul;
            var count = src.Length;
            ref readonly var item = ref first(src);
            for(var i=0; i<count; i++)
                total += skip(item,i).Width;
            return total;
        }
    }
}