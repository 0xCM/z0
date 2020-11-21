//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    public static class IntervalOps
    {
        /// <summary>
        /// Computes the length of the interval by finding the magnitude of the difference
        /// between its left/right endpoints
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <typeparam name="T">The primal numeric type over which the interval is defined</typeparam>
        [MethodImpl(Inline)]
        public static T Length<T>(this Interval<T> src)
            where T : unmanaged
                => gmath.length(src);

        public static string Format<T>(this Span<Interval<T>> parts, char? sep = null)
            where T : unmanaged
                => parts.Map(x => x.Format()).Concat($" {sep ?? Chars.Plus} ");
    }
}