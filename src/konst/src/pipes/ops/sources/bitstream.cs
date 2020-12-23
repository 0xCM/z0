//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static z;

    partial struct Sources
    {
        /// <summary>
        /// Produces an interminable stream of <see cref='bit'/> values
        /// </summary>
        /// <param name="random">The value source</param>
        public static IEnumerable<bit> bitstream(IDataSource src)
        {
            while(true)
            {
                var data = src.Next<ulong>();
                for(byte i=0; i<64; i++)
                    yield return BitStates.test(data,i);
            }
        }

        /// <summary>
        /// Produces an interminable stream of random values from a numeric domain {0,1}
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The numeric type</typeparam>
        public static IEnumerable<T> bitstream<T>(IDataSource src)
            where T : unmanaged
        {
            while(true)
            {
                var data = src.Next<ulong>();
                for(byte i=0; i<64; i++)
                    yield return force<byte,T>((byte)BitStates.test(data,i));
            }
        }
    }
}