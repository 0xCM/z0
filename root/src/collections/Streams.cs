//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    public static class Streams
    {
        public static IEnumerable<bit> bitstream<T>(T src)
            where T : struct
        {
            var bytes = Bytes.from(src).ToArray();
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
        public static IEnumerable<bit> bitstream<T>(IEnumerator<T> src)
            where T : struct
        {
            while(src.MoveNext())
                foreach(var b in bitstream(src.Current))
                    yield return b;
        }

        /// <summary>
        /// Transforms an primal source stream into a bitstream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<bit> bitstream<T>(IEnumerable<T> src)
            where T : struct
                => bitstream<T>(src.GetEnumerator());
    }
}