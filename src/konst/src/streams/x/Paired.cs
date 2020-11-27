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
                => Sources.paired<S,T>(source);

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
    }
}