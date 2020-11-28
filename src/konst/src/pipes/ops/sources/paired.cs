//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Sources
    {
        /// <summary>
        /// Yields a source-provided heterogenous pairs
        /// </summary>
        /// <param name="source">The value source</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static Paired<S,T> paired<S,T>(ISource source)
            where S : struct
            where T : struct
                => Tuples.paired(source.Next<S>(), source.Next<T>());
    }
}