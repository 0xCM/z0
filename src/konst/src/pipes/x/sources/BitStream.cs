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

    partial class XSource
    {
        /// <summary>
        /// Produces an interminable stream of random bits
        /// </summary>
        /// <param name="src">The data source</param>
        public static IEnumerable<Bit32> BitStream32(this IDataSource src)
        {
            const int w = 64;
            while(true)
            {
                var data = src.Next<ulong>();
                for(var i=0; i<w; i++)
                    yield return Bit32.test(data,i);
            }
        }

        /// <summary>
        /// Produces an interminable stream of random bits
        /// </summary>
        /// <param name="src">The data source</param>
        public static IEnumerable<bit> BitStream(this IDataSource src)
            => Sources.bitstream(src);

        /// <summary>
        /// Produces an interminable stream of random bits from a value sequence of parametric type
        /// </summary>
        /// <param name="random">The data source</param>
        public static IEnumerable<T> BitStream<T>(this IDataSource src)
            where T : unmanaged
                => Sources.bitstream<T>(src);

        /// <summary>
        /// Transforms an primal enumerator into a bitstream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static IEnumerable<bit> BitStream<T>(this IEnumerator<T> src)
            where T : struct
                => BitStreams.create(src);

        /// <summary>
        /// Transforms an primal source stream into a bitstream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static IEnumerable<bit> BitStream<T>(this IEnumerable<T> src)
            where T : struct
                => BitStreams.create(src);
    }
}