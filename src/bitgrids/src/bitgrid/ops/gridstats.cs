//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    partial class BitGrid
    {
        /// <summary>
        /// Calcuates grid map statistics
        /// </summary>
        /// <param name="src">The source map</param>
        [MethodImpl(Inline), Op]
        public static GridStats gridstats(GridMap src)
            => GridStats.Define(src);

        /// <summary>
        /// Computes grid map summary information
        /// </summary>
        /// <param name="map">The map to summarize</param>
        [MethodImpl(Inline)]
        public static GridStats gridstats<T>(ushort rows, ushort cols)
            where T : unmanaged
                => gridstats(gridmap(specify<T>(rows,cols)));

        /// <summary>
        /// Computes grid map summary information
        /// </summary>
        /// <param name="map">The map to summarize</param>
        [MethodImpl(Inline)]
        public static GridStats gridstats(ushort rows, ushort cols, ushort segwidth)
            => gridstats(gridmap(specify(rows, cols, segwidth)));
    }
}