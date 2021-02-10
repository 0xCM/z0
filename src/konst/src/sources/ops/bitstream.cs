//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    partial struct Sources
    {
        /// <summary>
        /// Produces an interminable stream of <see cref='bit'/> values
        /// </summary>
        /// <param name="random">The value source</param>
        [Op]
        public static IEnumerable<bit> bitstream(IDataSource src)
        {
            while(true)
            {
                var data = src.Next<ulong>();
                for(byte i=0; i<64; i++)
                    yield return bit.test(data,i);
            }
        }

        /// <summary>
        /// Produces an interminable stream of random values from a numeric domain {0,1}
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [Op, Closures(Closure)]
        public static IEnumerable<T> bitstream<T>(IDataSource src)
            where T : unmanaged
        {
            while(true)
            {
                var data = src.Next<ulong>();
                for(byte i=0; i<64; i++)
                    yield return Numeric.force<byte,T>((byte)bit.test(data,i));
            }
        }

        /// <summary>
        /// Transforms an primal source stream into a bitstream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static IEnumerable<bit> bitstream<T>(IEnumerable<T> src)
            where T : struct
                => bitstream<T>(src.GetEnumerator());

        /// <summary>
        /// Transforms an primal enumerator into a bitstream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IEnumerable<bit> bitstream<T>(IEnumerator<T> src)
            where T : struct
        {
            var buffer = alloc<bit>(size<T>());
            while(src.MoveNext())
            {
                bit.unpack(src.Current, buffer.Clear());
                foreach(var b in buffer)
                    yield return b;
            }
        }
    }
}