//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    partial struct Sources
    {
        /// <summary>
        /// Produces an interminable stream of random bytes
        /// </summary>
        /// <param name="src">The data source</param>
        [Op]
        public static IEnumerable<byte> bytes(ISource source)
        {
            while(true)
            {
                var u64 = source.Next<ulong>();
                for(byte i=0; i<8; i++)
                    yield return @byte(u64, i);
            }
        }

        /// <summary>
        /// Produces a limited stream of random bytes
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="count">The maximum number of bytes to produce</param>
        [Op]
        public static IEnumerable<byte> bytes(ISource source, int count)
        {
            var counter = 0;
            var bytes = new byte[8];
            for(var j=0; j<count; j+=8)
            {
                var src = source.Next<ulong>();
                memory.deposit(src, bytes);
                for(var k=0; k<8; k++, counter++)
                {
                    if(counter == count)
                        break;

                    yield return bytes[k];
                }
            }
        }

        public static IEnumerable<byte> bytes(ISource source, uint count)
            => bytes(source, (int)count);
    }
}