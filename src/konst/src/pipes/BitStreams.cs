//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.BitStream, true)]
    public readonly struct BitStreams
    {
        /// <summary>
        /// Transforms an primal source stream into a bitstream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Deferred<bit> create<T>(IEnumerable<T> src)
            where T : struct
                => Collective.defer(from<T>(src.GetEnumerator()));

        /// <summary>
        /// Transforms an primal enumerator into a bitstream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The primal type</typeparam>
        static IEnumerable<bit> from<T>(IEnumerator<T> src)
            where T : struct
        {
            while(src.MoveNext())
                foreach(var b in Bit.unpack(src.Current))
                    yield return b;
        }
    }
}