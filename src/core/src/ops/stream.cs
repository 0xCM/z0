//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    partial struct core
    {
        /// <summary>
        /// Procduces a possibly-empty but finite value stream
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <param name="src">The items included in the stream</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IEnumerable<T> stream<T>(params T[] src)
            => src;
    }
}