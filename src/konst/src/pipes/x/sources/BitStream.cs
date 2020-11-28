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
        /// <param name="source">The random source</param>
        public static IEnumerable<Bit32> BitStream32(this ISource source)
        {
            const int w = 64;
            while(true)
            {
                var data = source.Next<ulong>();
                for(var i=0; i<w; i++)
                    yield return Bit32.test(data,i);
            }
        }

        /// <summary>
        /// Produces an interminable stream of random bits
        /// </summary>
        /// <param name="source">The random source</param>
        public static IEnumerable<bit> BitStream(this ISource source)
            => Sources.bitstream(source);

        /// <summary>
        /// Produces an interminable stream of random bits from a value sequence of parametric type
        /// </summary>
        /// <param name="random">The random source</param>
        public static IEnumerable<T> BitStream<T>(this ISource source)
            where T : unmanaged
                => Sources.bitstream<T>(source);
    }
}