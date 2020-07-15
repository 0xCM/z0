//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.InteropServices.MemoryMarshal;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct z
    {
        /// <summary>
        /// Presents a generic value as a bytespan
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<byte> bytes<T>(in T src)
            where T : struct
                => AsBytes(CreateSpan(ref edit(src), 1));

        /// <summary>
        /// Presents a span of generic values as bytespan
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<byte> bytes<T>(Span<T> src)
            where T : struct
                => AsBytes(src);        

        /// <summary>
        /// Presents a readonly span over T-cells as a readonly bytespan
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<byte> bytes<T>(ReadOnlySpan<T> src)
            where T : struct
                => cover<byte>(cast<T,byte>(first(src)), src.Length*SizeOf<T>());

        /// <summary>
        /// Presents a selected segment of T-cels from a soruce span as a readonly bytespan
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="length">The source length</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<byte> bytes<T>(Span<T> src, int offset)
            where T : struct
                => bytes(slice(src,offset));

        /// <summary>
        /// Converts a specified number of source elements to bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <param name="count">The number of source elements to convert</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> bytes<T>(Span<T> src, int offset, int count)
            where T : struct
                => bytes(slice(src,offset,count));

        /// <summary>
        /// Converts a specified number of source elements to bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <param name="count">The number of source elements to convert</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> bytes<T>(Span<T> src, int offset, int? length)
            where T : struct
                => length == null ? bytes(src,offset) : bytes(src, offset, length.Value);

        /// <summary>
        /// Converts a specified number of source elements to bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <param name="count">The number of source elements to convert</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<byte> bytes<T>(ReadOnlySpan<T> src, int offset, int count)
            where T : struct
                => bytes(slice(src,offset,count));

        /// <summary>
        /// Presents a selected segment of a readonly span over T-cells as a readonly bytespan
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="length">The source length</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<byte> bytes<T>(ReadOnlySpan<T> src, int offset)
            where T : struct
                => bytes(slice(src,offset)); 

    }
}