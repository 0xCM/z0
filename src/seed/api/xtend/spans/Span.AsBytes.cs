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

    partial class XTend
    {
        /// <summary>
        /// Reimagines a span of bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> As<T>(this Span<byte> src)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> As<T>(this Span<uint> src)
            where T : unmanaged
                => MemoryMarshal.Cast<uint,T>(src);

        /// <summary>
        /// Presents selected span content as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="length">The source length</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsBytes<T>(this Span<T> src, int offset = 0, int ? length = null)
            where T : struct
            =>   (offset == 0 && length == null) 
                ? MemoryMarshal.AsBytes(src)
                : length == null  
                ? MemoryMarshal.AsBytes(src.Slice(offset)) 
                : MemoryMarshal.AsBytes(src.Slice(offset, length.Value));

        /// <summary>
        /// Reimagines a span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsBytes<T>(this Span<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src);

        /// <summary>
        /// Presents selected span content as a readonly span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="length">The source length</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> AsBytes<T>(this ReadOnlySpan<T> src, int offset = 0, int ? length = null)
            where T : struct
            =>   (offset == 0 && length == null) 
                ? MemoryMarshal.AsBytes(src)
                : length == null  
                ? MemoryMarshal.AsBytes(src.Slice(offset)) 
                : MemoryMarshal.AsBytes(src.Slice(offset, length.Value));

        /// <summary>
        /// Reimagines a readonly span of generic values as a span of readonly bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source span element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> AsBytes<T>(this ReadOnlySpan<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src);
    }
}