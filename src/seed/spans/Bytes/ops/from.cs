//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static Root;

    partial struct Bytes 
    {
        /// <summary>
        /// Constructs a span from a parameter array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        static Span<T> span<T>(params T[] src)
            => src;

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
        /// Converts the source value to a bytespan
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> from<T>(T src)
            where T : struct
                => MemoryMarshal.AsBytes(span(src));

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
            As.generic<T>(ref seek(ref head(dst), offset)) = src;
            return dst;
        }
    }
}