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
    using static z;

    [ApiHost]
    public readonly partial struct ByteReader
    {
        /// <summary>
        /// Reads at most size[T] bytes as determined by the length of the data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The unsigned numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
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
                return Read1(src, n1);
            else if(count == 2)
                return Read2(src, n2);
            else if(count == 3)
                return Read3(src, n3);
            else if(count == 4)
                return Read4(src, n4);
            else if(count == 5)
                return Read5(src, n5);
            else if(count == 6)
                return Read6(src, n6);
            else if(count == 7)
                return Read7(src, n7);
            else if(count == 8)
                return Read8(src, n8);
            else
                return 0;
        }

        /// <summary>
        /// Reads 1 byte from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong Read1(in byte src, N1 n)
        {
            var dst = 0ul;
            seek8(dst, 0) = skip(src,0);
            return dst;        
        }
        
        /// <summary>
        /// Reads 2 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong Read2(in byte src, N2 n)
        {
            var dst = 0ul;
            var i = 0u;
            seek8(dst, i++) = skip(src,i);
            seek8(dst, i++) = skip(src,i);
            return dst;        
        }

        /// <summary>
        /// Reads 3 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong Read3(in byte src, N3 n)
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
        public static ulong Read4(in byte src, N4 n)
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
        public static ulong Read5(in byte src, N5 n)
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

        /// <summary>
        /// Reads 6 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong Read6(in byte src, N6 n)
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
        public static ulong Read7(in byte src, N7 n)
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
        public static ulong Read8(in byte src, N8 n)
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