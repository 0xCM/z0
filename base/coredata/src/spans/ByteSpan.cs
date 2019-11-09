//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    public static class ByteSpan
    {
        /// <summary>
        /// Creates a span of byes from a source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>                
        [MethodImpl(Inline)]
        public static Span<byte> FromValue<T>(in T src)
            where T : unmanaged
        {
            Span<T> s = new T[1]{src};
            return MemoryMarshal.AsBytes(s);
        }        

        /// <summary>
        /// Presents a source reference as a byte reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref byte ByteRef<T>(ref T src)
            where T : unmanaged
                => ref Unsafe.As<T,byte>(ref src);


        /// <summary>
        /// Presents a source reference as a span of bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<byte> From<T>(ref T src)
            where T : unmanaged
                => MemoryMarshal.CreateSpan(ref ByteRef(ref src), Unsafe.SizeOf<T>()); 

        /// <summary>
        /// Reads a value from the head of a bytespan
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static T ReadValue<T>(ReadOnlySpan<byte> src)
            where T : unmanaged        
                => MemoryMarshal.Read<T>(src);

        /// <summary>
        /// Reads a value from a bytespan beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The index at which span consumption should begin</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static T ReadValue<T>(ReadOnlySpan<byte> src, int offset)
            where T : unmanaged        
                => MemoryMarshal.Read<T>(src.Slice(offset));

        /// <summary>
        /// Writes a value into a btypespan
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static void WriteValue<T>(in T src, Span<byte> dst)
            where T : unmanaged
                => MemoryMarshal.Write(dst, ref Unsafe.AsRef(in src));

        /// <summary>
        /// Interprets the readonly source span as a span of readonly bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> AsBytes<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => MemoryMarshal.AsBytes(src);

        /// <summary>
        /// Interprets a readonly source span as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of source elements to skip from the head</param>
        /// <param name="length">Tne number of source elements to read</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> AsBytes<T>(ReadOnlySpan<T> src, int offset, int length)
            where T : unmanaged
                => MemoryMarshal.AsBytes(src.Slice(offset,length));

        /// <summary>
        /// Interprets a source span as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsBytes<T>(Span<T> src)
            where T : unmanaged
                => MemoryMarshal.AsBytes(src);

        /// <summary>
        /// Interprets a source span as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of source elements to skip from the head</param>
        /// <param name="length">Tne number of source elements to read</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsBytes<T>(Span<T> src, int offset, int length)
            where T : unmanaged
                => MemoryMarshal.AsBytes(src.Slice(offset,length));

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> Cast<T>(ReadOnlySpan<byte> src, int offset, int length)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(src.Slice(offset, length * Unsafe.SizeOf<T>()));

        [MethodImpl(Inline)]
        public static Span<T> Cast<T>(Span<byte> src, int offset, int length)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(src.Slice(offset, length * Unsafe.SizeOf<T>()));
        
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> Cast<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
                => Cast<T>(src, 0, src.Length/Unsafe.SizeOf<T>());

        [MethodImpl(Inline)]
        public static Span<T> Cast<T>(Span<byte> src)
            where T : unmanaged        
                => Cast<T>(src, 0, src.Length/Unsafe.SizeOf<T>());

        public static Span<T> Cast<T>(Span<byte> src, out Span<byte> rem)
            where T : unmanaged        
        {
            rem = Span<byte>.Empty;
            var tSize = Unsafe.SizeOf<T>();
            var dst = Cast<T>(src);
            var q = Math.DivRem(dst.Length, tSize, out int r);
            if(r != 0)
                rem = src.Slice(dst.Length*tSize);
            return dst;
        }

    }

}