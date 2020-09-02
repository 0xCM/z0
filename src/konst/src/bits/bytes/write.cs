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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> write<T>(in T src)
            where T : struct
        {
            Span<byte> dst =  new byte[size<T>()];
            write(src,dst);
            return dst;
        }

        /// <summary>
        /// Writes a structural value value to a span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void write<T>(in T src, Span<byte> dst)
            where T : struct
        {
            seek(recover<byte,T>(dst), 0) = src;
        }        
    }
}