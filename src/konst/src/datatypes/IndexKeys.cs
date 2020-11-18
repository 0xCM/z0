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

    [ApiHost]
    public readonly struct IndexKeys
    {
        [MethodImpl(Inline)]
        public static IndexKeys<K,I> define<K,I>(IndexKey<K,I>[] src, I min, I max)
            where K : unmanaged
            where I : unmanaged
                => new IndexKeys<K,I>(src, min, max);

        /// <summary>
        /// Correlates an identifying key and a sequence/index postion
        /// </summary>
        /// <param name="key">The identifying key</param>
        /// <param name="index">The correlated position</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="I">The index type</typeparam>
        [MethodImpl(Inline)]
        public static IndexKey<K,I> index<K,I>(K key, I index)
            where K : unmanaged
            where I : unmanaged
                => new IndexKey<K,I>(key,index);


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ClosedInterval<ulong> indices<I>(in ClosedInterval<ulong> points, I min, I max)
            where I : unmanaged
        {
            var offset = points.Min;
            var left = uint64(min) - offset;
            var right = uint64(max) - offset;
            return (left,right);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ClosedInterval<ulong> positions<I>(I min, I max)
            where I : unmanaged
                => Intervals.closed(uint64(min), uint64(max));
    }
}