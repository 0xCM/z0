//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial struct Sources
    {
        /// <summary>
        /// Yields a source-provided heterogenous pairs
        /// </summary>
        /// <param name="src">The value source</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static Paired<S,T> paired<S,T>(ISource src)
            where S : struct
            where T : struct
                => Tuples.paired(src.Next<S>(), src.Next<T>());
    }
}