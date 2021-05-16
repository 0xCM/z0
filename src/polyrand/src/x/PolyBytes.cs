//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public static class PolyBytes
    {
        /// <summary>
        /// Produces an interminable stream of random bytes
        /// </summary>
        /// <param name="src">The data source</param>
        public static IEnumerable<byte> Bytes(this ISource src)
            => Sources.bytes(src);

        /// <summary>
        /// Produces a limited stream of random bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The maximum number of bytes to produce</param>
        public static IEnumerable<byte> Bytes(this ISource src, int count)
            => Sources.bytes(src, count);

        /// <summary>
        /// Produces a limited stream of random bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The maximum number of bytes to produce</param>
        public static IEnumerable<byte> Bytes(this ISource src, uint count)
            => Sources.bytes(src, count);
    }
}