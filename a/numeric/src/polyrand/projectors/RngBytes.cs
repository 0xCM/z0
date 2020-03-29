//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Core;

    public static class RngBytes
    {
        /// <summary>
        /// Produces an interminable stream of random bytes
        /// </summary>
        /// <param name="random">The random source</param>
        public static IEnumerable<byte> Bytes(this IPolyrand random)
        {
            var cache = new byte[8];
            while(true)
            {
                var src = random.Next<ulong>();
                BitConvert.GetBytes(src,cache);   
                for(var i=0; i < cache.Length; i++)
                    yield return cache[i];
            }
        }

        /// <summary>
        /// Produces a limited stream of random bytes
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="count">The maximum number of bytes to produce</param>
        public static IEnumerable<byte> Bytes(this IPolyrand random, int count)
        {
            var counter = 0;
            var bytes = new byte[8];
            for(var j=0; j<count; j+=8)
            {
                var src = random.Next<ulong>();
                BitConvert.GetBytes(src, bytes);   
                for(var k=0; k<8; k++, counter++)
                {
                    if(counter == count)
                        break;  

                    yield return bytes[k];
                }
            }
        }

        /// <summary>
        /// Produces a random stream of bytes
        /// </summary>
        /// <param name="random">The random source</param>
        public static IRngStream<byte> ByteStream(this IPolyrand random)
        {
            IEnumerable<byte> produce()
            {
                while(true)
                {
                    var bytes = BitConverter.GetBytes(random.Next<ulong>());
                    for(var i = 0; i< bytes.Length; i++)
                        if(i == 0)
                            yield return bytes[i];
                }
            }
            return PolyStream.create(produce(), random.RngKind);
        }
    }
}