//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial class XSource
    {
        /// <summary>
        /// Produces an interminable stream of random bytes
        /// </summary>
        /// <param name="source">The data source</param>
        public static IEnumerable<byte> Bytes(this ISource source)
        {
            var cache = new byte[8];
            while(true)
            {
                var src = source.Next<ulong>();
                Sinks.deposit(src,cache);
                for(var i=0; i < cache.Length; i++)
                    yield return cache[i];
            }
        }

        /// <summary>
        /// Produces a limited stream of random bytes
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="count">The maximum number of bytes to produce</param>
        public static IEnumerable<byte> Bytes(this ISource source, int count)
        {
            var counter = 0;
            var bytes = new byte[8];
            for(var j=0; j<count; j+=8)
            {
                var src = source.Next<ulong>();
                Sinks.deposit(src, bytes);
                for(var k=0; k<8; k++, counter++)
                {
                    if(counter == count)
                        break;

                    yield return bytes[k];
                }
            }
        }
    }
}