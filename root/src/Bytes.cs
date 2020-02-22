//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Root;
    using static As;
    using static Refs;
    using static SpanOps;

    public static class Bytes
    {
        /// <summary>
        /// Reads/writes a byte from/to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="offset">The 0-based/byte-relative offset</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(Inline)]
        public static ref byte single<T>(ref T src, int offset)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<T,byte>(ref src), offset);

        /// <summary>
        /// Allocates and reads a byte array from an unmanaged source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The soruce type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> read<T>(in T src)
            where T : unmanaged
        {
            Span<byte> dst = new byte[size<T>()];
            Unsafe.As<byte, T>(ref head(dst)) = src;
            return dst;
        }

        /// <summary>
        /// Reads a byte array from an unmanaged source value and stored the result in a caller-allocated target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target array</param>
        /// <typeparam name="T">The soruce type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> read<T>(in T src, Span<byte> dst)
            where T : unmanaged
        {
            Unsafe.As<byte, T>(ref head(dst)) = src;
            return dst;
        }

        /// <summary>
        /// Reads an unmanaged generic value from a bytespan beginning at a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The source array offset</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T read<T>(Span<byte> src, int offset = 0)
            where T : unmanaged
                => Unsafe.ReadUnaligned<T>(ref seek(ref head(src), offset));

        /// <summary>
        /// Reads an unmanaged generic value from a readonly bytespan beginning at a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The source span offset</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T read<T>(ReadOnlySpan<byte> src, int offset = 0)
            where T : unmanaged
                =>  Unsafe.ReadUnaligned<T>(ref mutable(skip(head(src), offset)));

        /// <summary>
        /// Reads an unmanaged generic value from a bytespan beginning at a specified offset
        /// and deposits the result in a caller-supplied target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The source span offset</param>
        /// <param name="dst">The target reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref T read<T>(Span<byte> src, int offset, ref T dst)
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
        [MethodImpl(Inline)]
        public static Span<byte> write<T>(in T src, Span<byte> dst, int offset)
            where T : unmanaged
        {
            generic<T>(ref seek(ref head(dst), offset)) = src;
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> write<T>(in T src)
            where T : unmanaged
        {
            Span<byte> dst =  new byte[size<T>()];
            generic<T>(ref head(dst)) = src;
            return dst;
        }
    }
}