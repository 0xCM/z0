//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static As;

    public static class Bytes
    {
        /// <summary>
        /// Reads/writes a byte from/to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="offset">The 0-based/byte-relative offset</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(Inline)]
        public static ref byte one<T>(ref T src, int offset)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<T,byte>(ref src), offset);

        /// <summary>
        /// Reads a single cell into a span of bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]   
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
        [MethodImpl(Inline)]
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
                => from(ref mutable(in src));

        /// <summary>
        /// Reads a byte array from an unmanaged source value and stored the result in a caller-allocated target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target array</param>
        /// <typeparam name="T">The soruce type</typeparam>
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
        public static ref T to<T>(Span<byte> src, int offset, ref T dst)
            where T : unmanaged
        {            
            dst = Unsafe.ReadUnaligned<T>(ref seek(ref head(src), offset));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> write<T>(in T src)
            where T : unmanaged
        {
            Span<byte> dst =  new byte[size<T>()];
            generic<T>(ref head(dst)) = src;
            return dst;
        }

        /// <summary>
        /// Writes an unmanaged source value to an array
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> from<T>(in T src, Span<byte> dst, int offset)
            where T : unmanaged
        {
            generic<T>(ref seek(ref head(dst), offset)) = src;
            return dst;
        }

        /// <summary>
        /// Reads a single byte froma byte source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static unsafe byte read8(in byte src)
            => *(byte*)constptr(in src);

        /// <summary>
        /// Reads 16 bits from a contiguous sequence of 2 bytes
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static unsafe ushort read16(in byte src)
            => *(ushort*)constptr(in src);

        /// <summary>
        /// Reads 32 bits from a contiguous sequence of 4 bytes
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static unsafe uint read32(in byte src)
            => *(uint*)constptr(in src);

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 8 bytes
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static unsafe ulong read64(in byte src)
            => *(ulong*)constptr(in src);
    }
}