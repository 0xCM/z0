//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    partial class XSource
    {
        /// <summary>
        /// Fills the target with parings taken from the source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The receiver</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static Pairings<S,T> Pairings<S,T>(this ISource src, uint count)
            where S : struct
            where T : struct
        {
            var dst = new Pairings<S,T>(new Paired<S,T>[count]);
            src.Pairings(dst);
            return dst;
        }

        /// <summary>
        /// Fills the target with parings taken from the source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The receiver</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static void Pairings<S,T>(this ISource src, Pairings<S,T> dst)
            where S : struct
            where T : struct
        {
            var count = dst.Count;
            var values = src.Pairings<S,T>();
            for(var i=0; i<count; i++)
                dst[i] = values.First();
        }

        /// <summary>
        /// Yields a stream of source-provided heterogenous pairs
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static IEnumerable<Paired<S,T>> Pairings<S,T>(this ISource src)
            where S : struct
            where T : struct
        {
            while(true)
                yield return src.Paired<S,T>();
        }
    }
}