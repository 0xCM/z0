//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XSource
    {
        /// <summary>
        /// Yields a source-provided heterogenous pairs
        /// </summary>
        /// <param name="src">The value source</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static Paired<S,T> Paired<S,T>(this IDataSource src)
            where S : struct
            where T : struct
                => Sources.paired<S,T>(src);
    }
}