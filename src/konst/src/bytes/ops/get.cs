//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Bytes 
    {
        /// <summary>
        /// Converts the source value to a bytespan
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> get<T>(in T src)
            where T : struct
                => z.bytes(src);
    }
}