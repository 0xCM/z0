//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static NumericCast;

    public static class PolyNique
    {
        /// <summary>
        /// Samples the source values without replacement
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="source">The data source</param>
        /// <param name="count">The number of values to sample</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static HashSet<T> Distinct<T>(this IPolyrand random,  T[] source, int count)
            => random.Distinct(source.Length, count).Select(i => source[i]).ToHashSet();

        public static HashSet<T> Distinct<T>(this IPolyrand random, T pool, int count)
            where T : unmanaged
        {
            var src = random.Stream(default(T), pool);
            var set = src.Take(count).ToHashSet();
            while(set.Count < count)
                set.WithItems(src.Take(count / 2));
            return set;
        }

        public static HashSet<T> Distinct<T>(this IPolyrand random, T pool, T count)
            where T : unmanaged
        {
            var src = random.Stream(default(T), pool);
            var _count = force<T,int>(count);
            var set = src.Take(_count).ToHashSet();
            while(set.Count < _count)
                set.WithItems(src.Take(_count / 2));
            return set;
        }

        /// <summary>
        /// Takes a specified number of distinct points from a source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The number of points to take</param>
        /// <typeparam name="T">The element type</typeparam>
        public static HashSet<T> Distinct<T>(this IPolyrand random, int count)
            where T : unmanaged
        {
            var stream = random.Stream<T>();
            var set = stream.Take(count).ToHashSet();
            while(set.Count < count)
                set.WithItems(stream.Take(set.Count - count));
            return set;
        }
    }
}