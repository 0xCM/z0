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

    partial class XTend
    {
        /// <summary>
        /// Yields a source-provided heterogenous pairs
        /// </summary>
        /// <param name="source">The value source</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static Paired<S,T> Paired<S,T>(this IValueSource source)
            where S : struct
            where T : struct
                => Tuples.paired(source.Next<S>(), source.Next<T>());

        /// <summary>
        /// Yields a stream of source-provided heterogenous pairs
        /// </summary>
        /// <param name="source">The value source</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static IEnumerable<Paired<S,T>> Pairings<S,T>(this IValueSource source)
            where S : struct
            where T : struct
        {
            while(true)
                yield return source.Paired<S,T>();
        }

        /// <summary>
        /// Fills the target with parings taken from the source
        /// </summary>
        /// <param name="source">The value source</param>
        /// <param name="dst">The receiver</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static Pairings<S,T> Pairings<S,T>(this IValueSource source, uint count)
            where S : struct
            where T : struct
        {
            var dst = new Pairings<S,T>(new Paired<S,T>[count]);
            source.Pairings(dst);
            return dst;
        }

        /// <summary>
        /// Fills the target with parings taken from the source
        /// </summary>
        /// <param name="source">The value source</param>
        /// <param name="dst">The receiver</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static void Pairings<S,T>(this IValueSource source, Pairings<S,T> dst)
            where S : struct
            where T : struct
        {
            var count = dst.Count;
            var values = source.Pairings<S,T>();
            for(var i=0; i<count; i++)
                dst[i] = values.First();
        }
    }
}