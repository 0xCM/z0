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
        /// <param name="random">The random source</param>
        public static IEnumerable<byte> Bytes(this IPolySourced random)
        {
            var cache = new byte[8];
            while(true)
            {
                var src = random.Next<ulong>();
                As.deposit(src,cache);
                for(var i=0; i < cache.Length; i++)
                    yield return cache[i];
            }
        }

        /// <summary>
        /// Produces a limited stream of random bytes
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The maximum number of bytes to produce</param>
        public static IEnumerable<byte> Bytes(this IPolySourced random, int count)
        {
            var counter = 0;
            var bytes = new byte[8];
            for(var j=0; j<count; j+=8)
            {
                var src = random.Next<ulong>();
                As.deposit(src, bytes);
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