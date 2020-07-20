//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Creates a bistream over a T-stream
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitStream<T> bitstream<T>(IEnumerable<T> src)
            where T : struct
                => new BitStream<T>(src);
    }
}