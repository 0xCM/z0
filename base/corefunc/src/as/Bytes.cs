//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.InteropServices;
    using Z0;
 
    using static zfunc;
    using static As;

    public static class Bytes
    {
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
        public static T read<T>(Span<byte> src, in int offset = 0)
            where T : unmanaged
                => Unsafe.ReadUnaligned<T>(ref seek(ref head(src), offset));

        /// <summary>
        /// Reads an unmanaged generic value from a readonly bytespan beginning at a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The source span offset</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T read<T>(ReadOnlySpan<byte> src, in int offset = 0)
            where T : unmanaged
                =>  Unsafe.ReadUnaligned<T>(ref asRef(skip(head(src), offset)));

        /// <summary>
        /// Reads an unmanaged generic value from a bytespan beginning at a specified offset
        /// and deposits the result in a caller-supplied target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The source span offset</param>
        /// <param name="dst">The target reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref T read<T>(Span<byte> src, in int offset, ref T dst)
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
        public static Span<byte> write<T>(in T src, Span<byte> dst, in int offset)
            where T : unmanaged
        {
            As.generic<T>(ref seek(ref head(dst), offset)) = src;
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> write<T>(in T src)
            where T : unmanaged
        {
            Span<byte> dst =  new byte[size<T>()];
            As.generic<T>(ref head(dst)) = src;
            return dst;
        }
    }
}