//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct ByteReader
    {
        /// <summary>
        /// Reads at most size[T] bytes as determined by the length of the data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The unsigned numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T read<T>(ReadOnlySpan<byte> src)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(read(first(src), (byte)src.Length));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(read(first(src), (byte)src.Length));
            else if(typeof(T) == typeof(uint))
                return generic<T>(read(first(src), (byte)src.Length));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(read(first(src), (byte)src.Length));
            else
                return default;
        }

        /// <summary>
        /// Reads at most 8 bytes from the data source, as determined by source length
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong read(ReadOnlySpan<byte> src)
            => read(first(src), (byte)src.Length);

        /// <summary>
        /// Reads up to 8 bytes from a data source reference, as determined by a specified {count} of bytes,
        /// and will likely incinerate the process with a segmentation fault if there aren't {count} bytes to read
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of bytes to read</param>
        [MethodImpl(Inline), Op]
        public static ulong read(in byte src, byte count)
        {
            if(count == 1)
                return read1(src);
            else if(count == 2)
                return read2(src);
            else if(count == 3)
                return read3(src);
            else if(count == 4)
                return read4(src);
            else if(count == 5)
                return read5(src);
            else if(count == 6)
                return read6(src);
            else if(count == 7)
                return read7(src);
            else if(count == 8)
                return read8(src);
            else
                return 0;
        }

        /// <summary>
        /// Reads 1 byte from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong read1(in byte src)
        {
            var dst = 0ul;
            seek8(dst, 0) = skip(src, 0);
            return dst;
        }

        /// <summary>
        /// Reads 2 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong read2(in byte src)
        {
            var dst = 0ul;
            var i = 0u;
            seek8(dst, i++) = skip(src, i);
            seek8(dst, i++) = skip(src, i);
            return dst;
        }

        /// <summary>
        /// Reads 3 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong read3(in byte src)
        {
            var dst = 0ul;
            var i = 0u;
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            return dst;
        }

        /// <summary>
        /// Reads 4 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong read4(in byte src)
        {
            var dst = 0ul;
            var i = 0u;
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            return dst;
        }

        /// <summary>
        /// Reads 5 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong read5(in byte src)
        {
            var dst = 0ul;
            var i = 0u;
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static byte read1(in byte src, Span<byte> dst)
        {
            first(dst) = src;
            return 1;
        }

        [MethodImpl(Inline), Op]
        public static byte read2(in byte src, Span<byte> dst)
        {
            first(recover<ushort>(dst)) = u16(src);
            return 2;
        }

        /// <summary>
        /// Reads 5 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static byte read3(in byte src, Span<byte> dst)
        {
            read2(src,dst);
            seek(dst,3) = skip(src,3);
            return 3;
        }

        [MethodImpl(Inline), Op]
        public static byte read4(in byte src, Span<byte> dst)
        {
            first(recover<uint>(dst)) = u32(src);
            return 4;
        }

        /// <summary>
        /// Reads 5 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static byte read5(in byte src, Span<byte> dst)
        {
            read4(src,dst);
            seek(dst,4) = skip(src,4);
            return 5;
        }

        /// <summary>
        /// Reads 6 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static byte read6(in byte src, Span<byte> dst)
        {
            read4(src,dst);
            read2(skip(src,4), slice(dst,4));
            return 6;
        }

        /// <summary>
        /// Reads 6 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static byte read7(in byte src, Span<byte> dst)
        {
            read4(src,dst);
            read3(skip(src,4), slice(dst,4));
            return 7;
        }

        /// <summary>
        /// Reads 6 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static byte read8(in byte src, Span<byte> dst)
        {
            first(recover<ulong>(dst)) = u64(src);
            return 8;
        }

        /// <summary>
        /// Reads 6 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong read6(in byte src)
        {
            var dst = 0ul;
            var i = 0u;
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            return dst;
        }


        /// <summary>
        /// Reads 7 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong read7(in byte src)
        {
            var dst = 0ul;
            var i = 0u;
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            return dst;
        }

        /// <summary>
        /// Reads 8 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong read8(in byte src)
        {
            var dst = 0ul;
            var i = 0u;
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            return dst;
        }
    }
}