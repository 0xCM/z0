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
    public readonly struct KeyMaps
    {
        [MethodImpl(Inline)]
        public static KeyMap<K,I> define<K,I>(KeyedIndex<K,I>[] src, I min, I max)
            where K : unmanaged
            where I : unmanaged
                => new KeyMap<K,I>(src, min, max);

        /// <summary>
        /// Correlates an identifying key and a sequence/index postion
        /// </summary>
        /// <param name="key">The identifying key</param>
        /// <param name="index">The correlated position</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="I">The index type</typeparam>
        [MethodImpl(Inline)]
        public static KeyedIndex<K,I> index<K,I>(K key, I index)
            where K : unmanaged
            where I : unmanaged
                => new KeyedIndex<K,I>(key,index);


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