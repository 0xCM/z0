//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;
    using static Memories;

    [ApiHost]
    public readonly struct Bytes : IApiHost<Bytes>
    {
        /// <summary>
        /// Reads a single cell into a span of bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> from<T>(ref T src)
            where T : struct
                => MemoryMarshal.CreateSpan(ref Edits.edit8(ref src), size<T>()); 

        /// <summary>
        /// Constructs a span from a parameter array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        static Span<T> span<T>(params T[] src)
            => src;

        /// <summary>
        /// Converts the source value to a bytespan
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> from<T>(T src)
            where T : struct
                => MemoryMarshal.AsBytes(span(src));

        /// <summary>
        /// Converts the source value to a bytespan
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> get<T>(in T src)
            where T : struct
                => from(ref edit(src));

        /// <summary>
        /// Reads a byte array from an unmanaged source value and stored the result in a caller-allocated target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target array</param>
        /// <typeparam name="T">The soruce type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void to<T>(in T src, Span<byte> dst)
            where T : struct
                => Unsafe.As<byte,T>(ref head(dst)) = src;

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
        /// Writes an unmanaged source value to an array
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> from<T>(in T src, Span<byte> dst, int offset)
            where T : struct
        {
            generic<T>(ref seek(ref head(dst), offset)) = src;
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> write<T>(in T src)
            where T : struct
        {
            Span<byte> dst =  new byte[size<T>()];
            generic<T>(ref head(dst)) = src;
            return dst;
        }

    }
}