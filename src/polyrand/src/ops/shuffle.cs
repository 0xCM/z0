//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    partial struct Sources
    {
        /// <summary>
        /// Shuffles span content in-place
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="target">The input/output span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [Op, Closures(Closure)]
        public static Span<T> shuffle<T>(IDomainSource src, Span<T> target)
        {
            for (var i = 0u; i<target.Length; i++)
                Swaps.swap(ref seek(target,i), ref seek(target,(uint)(i + src.Next(0, target.Length - i))));
            return target;
        }
    }
}