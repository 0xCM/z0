//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static core;

    partial struct Sources
    {
        /// <summary>
        /// Yields a stream of source-provided heterogenous pairs
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static IEnumerable<Paired<S,T>> pairings<S,T>(ISource src)
            where S : struct
            where T : struct
        {
            while(true)
                yield return paired<S,T>(src);
        }

        /// <summary>
        /// Fills the target with parings taken from the source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The receiver</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static void pairings<S,T>(ISource src, Pairings<S,T> dst)
            where S : struct
            where T : struct
        {
            var count = dst.Count;
            var values = pairings<S,T>(src).Take(count).Array();
            for(var i=0; i<count; i++)
                dst[i] = skip(values,i);
        }
    }
}