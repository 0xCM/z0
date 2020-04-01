//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Memories;
    using static refs;
    using static As;

    [ApiHost]
    public static class Bytes
    {
        /// <summary>
        /// Reads/writes a byte from/to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="offset">The 0-based/byte-relative offset</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref byte one<T>(ref T src, int offset)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<T,byte>(ref src), offset);

        /// <summary>
        /// Reads a single cell into a span of bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Span<byte> from<T>(ref T src)
            where T : struct
                => MemoryMarshal.CreateSpan(ref refs.byterefR(ref src), size<T>()); 

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
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Span<byte> from<T>(T src)
            where T : struct
                => MemoryMarshal.AsBytes(span(src));

        /// <summary>
        /// Converts the source value to a bytespan
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> get<T>(in T src)
            where T : unmanaged
                => from(ref edit(in src));

        /// <summary>
        /// Reads a byte array from an unmanaged source value and stored the result in a caller-allocated target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target array</param>
        /// <typeparam name="T">The soruce type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static void to<T>(in T src, Span<byte> dst)
            where T : unmanaged
                => Unsafe.As<byte, T>(ref head(dst)) = src;

        /// <summary>
        /// Reads an unmanaged generic value from a bytespan beginning at a specified offset and deposits the result in a caller-supplied target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The source span offset</param>
        /// <param name="dst">The target reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T to<T>(Span<byte> src, int offset, ref T dst)
            where T : unmanaged
        {            
            dst = Unsafe.ReadUnaligned<T>(ref seek(ref head(src), offset));
            return ref dst;
        }

        /// <summary>
        /// Writes an unmanaged source value to an array
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Span<byte> from<T>(in T src, Span<byte> dst, int offset)
            where T : unmanaged
        {
            generic<T>(ref seek(ref head(dst), offset)) = src;
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Span<byte> write<T>(in T src)
            where T : unmanaged
        {
            Span<byte> dst =  new byte[size<T>()];
            generic<T>(ref head(dst)) = src;
            return dst;
        }

        /// <summary>
        /// Reads the bytes that define a numeric value
        /// </summary>
        /// <param name="src">The value to read</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> from(short src)
            => new Span<byte>(constptr(in src), 2);

        /// <summary>
        /// Reads the bytes that define a numeric value
        /// </summary>
        /// <param name="src">The value to read</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> from(ushort src)
            => new Span<byte>(constptr(in src), 2);

        /// <summary>
        /// Reads the bytes that define a numeric value
        /// </summary>
        /// <param name="src">The value to read</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> from(int src)
            => new Span<byte>(constptr(in src), 4);

        /// <summary>
        /// Reads the bytes that define a numeric value
        /// </summary>
        /// <param name="src">The value to read</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> from(uint src)
            => new Span<byte>(constptr(in src), 4);

        /// <summary>
        /// Reads the bytes that define a numeric value
        /// </summary>
        /// <param name="src">The value to read</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> from(long src)
            => new Span<byte>(constptr(in src), 8);

        /// <summary>
        /// Reads the bytes that define a numeric value
        /// </summary>
        /// <param name="src">The value to read</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> from(ulong src)
            => new Span<byte>(constptr(in src), 8);

        /// <summary>
        /// Reads the bytes that define a numeric value
        /// </summary>
        /// <param name="src">The value to read</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> from(float src)
            => new Span<byte>(constptr(in src), 4);

        /// <summary>
        /// Reads the bytes that define a numeric value
        /// </summary>
        /// <param name="src">The value to read</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> from(double src)
            => new Span<byte>(constptr(in src), 8);            
    }
}