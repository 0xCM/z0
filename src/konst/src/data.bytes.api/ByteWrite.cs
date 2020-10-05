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

    [ApiHost]
    public readonly struct ByteWrite
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
        /// Reads a byte array from an unmanaged source value and stored the result in a caller-allocated target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target array</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void to<T>(in T src, Span<byte> dst)
            where T : struct
                => first(recover<byte,T>(dst)) = src;

        /// <summary>
        /// Reads/writes a byte from/to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="offset">The 0-based/byte-relative offset</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref byte one<T>(ref T src, int offset)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<T,byte>(ref src), offset);

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
                => seek(recover<byte,T>(dst), 0) = src;
    }
}