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

    using static Konst;
    using static Control;

    [ApiHost]
    public readonly struct BitStream
    {
        /// <summary>
        /// Populates a caller-supplied target with unpacked source bits
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The data source type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void to<T>(T src, Span<Bit> dst)
            where T : struct
        {
            var data = bytes(src);
            var count = length(data,dst);
            for(var i=0; i< data.Length; i++)
            {
                ref readonly var b = ref skip(data,i);
                for(var j=0; j<8; j++)
                    seek(dst,j) = bit.test(b,j);
            }
        }

        public static IEnumerable<bit> from<T>(T src)
            where T : struct
        {
            var bytes = Control.bytes(src).ToArray();
            for(var i=0; i< bytes.Length; i++)
            {
                var b = bytes[i];
                for(var j=0; j<8; j++)
                    yield return bit.test(b,j);
            }
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
        
        [MethodImpl(Inline)]
        public static IStreamSource<bit> source<T>(IEnumerable<T> src)
            where T : struct
                => new BitStream<T>(src);
    }
}