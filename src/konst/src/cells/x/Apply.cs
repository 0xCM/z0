//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;

    using static CellSource;
    using static Konst;

    partial class CellX
    {
        /// <summary>
        /// Creates a stream of fixed values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static IEnumerable<F> CellStream<F>(this IPolyrand random)
            where F: unmanaged, IDataCell
                => CellSource.stream(create<F>(random));
    }
}