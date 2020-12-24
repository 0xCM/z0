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

    [ApiHost(ApiNames.BitStream, true)]
    public readonly struct BitStreams
    {
        /// <summary>
        /// Transforms an primal source stream into a bitstream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static IEnumerable<bit> create<T>(IEnumerable<T> src)
            where T : struct
                => create<T>(src.GetEnumerator());

        /// <summary>
        /// Transforms an primal enumerator into a bitstream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static IEnumerable<bit> create<T>(IEnumerator<T> src)
            where T : struct
        {
            var buffer = alloc<bit>(size<T>());
            while(src.MoveNext())
            {
                Bit.unpack(src.Current, buffer.Clear());
                foreach(var b in buffer)
                    yield return b;
            }
        }
    }
}