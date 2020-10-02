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
    public readonly struct BitStream
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit[] from<T>(T src)
            where T : struct
        {
            var width = bitsize<T>();
            var size = z.size<T>();
            ref readonly var input = ref uint8(ref src);
            var buffer = sys.alloc<bit>(width);
            ref var dst = ref first(span(buffer));

            for(var i=0u; i<size; i++)
            {
                ref readonly var b = ref skip(input,i);
                for(byte j=0; j<8; j++)
                    seek(dst,j) = bit.test(b,j);
            }
            return buffer;
        }

        /// <summary>
        /// Transforms an primal enumerator into a bitstream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The primal type</typeparam>
        public static IEnumerable<bit> from<T>(IEnumerator<T> src)
            where T : struct
        {
            while(src.MoveNext())
                foreach(var b in from(src.Current))
                    yield return b;
        }

        /// <summary>
        /// Transforms an primal source stream into a bitstream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<bit> from<T>(IEnumerable<T> src)
            where T : struct
                => from<T>(src.GetEnumerator());

    }
}