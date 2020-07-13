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
    using static z;

    [ApiHost]
    public readonly struct BitStream
    {
        public static bit[] from<T>(T src)
            where T : struct
        {
            var bytes = z.bytes(src);
            var buffer = sys.alloc<bit>(bytes.Length*8);
            var dst = span(buffer);
            
            for(var i=0u; i<bytes.Length; i++)
            {
                var b = skip(bytes,i);
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
        
        // [MethodImpl(Inline)]
        // public static IStreamSource<bit> source<T>(IEnumerable<T> src)
        //     where T : struct
        //         => new BitStream<T>(src);
    }
}