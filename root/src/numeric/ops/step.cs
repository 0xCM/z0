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

    using static Root;

    partial class Numeric
    {
        /// <summary>
        /// Creates an enumerable sequence that ranges between inclusive upper and lower bounds
        /// </summary>
        /// <param name="x0">The lower bound</param>
        /// <param name="x1">The upper bound</param>
        /// <param name="step">The step size</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static IEnumerable<T> step<T>(T x0, T x1, T step)
            where T : unmanaged
                => range_1(x0,x1,step);
    }
}