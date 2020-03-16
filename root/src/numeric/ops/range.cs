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
    using System.Collections.Concurrent;

    using static Root;

    partial class Numeric
    {
        /// <summary>
        /// Creates the numeric sequence {0,1,...,count-1}
        /// </summary>
        /// <param name="count">The number of elements in the sequence</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static IEnumerable<T> range<T>(T count)
            where T : unmanaged
                => NumericRange.counted(count);

        /// <summary>
        /// Creates a numeric sequence that ranges between inclusive upper and lower bounds
        /// </summary>
        /// <param name="x0">The lower bound</param>
        /// <param name="x1">The upper bound</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static IEnumerable<T> range<T>(T x0, T x1)
            where T : unmanaged
                => NumericRange.sequence(x0,x1);

        /// <summary>
        /// Creates a numeric sequence that ranges between inclusive upper and lower bounds
        /// </summary>
        /// <param name="x0">The lower bound</param>
        /// <param name="x1">The upper bound</param>
        /// <param name="step">The step size</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static IEnumerable<T> range<T>(T x0, T x1, T step)
            where T : unmanaged
                => NumericRange.step(x0,x1,step);
    }
}