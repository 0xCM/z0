//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static refs;

    [ApiHost]
    public readonly partial struct ByteReader : IApiHost<ByteReader>
    {
        /// <summary>
        /// Reads at most 8 bytes from the data source, as determined by source length
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(ReadOnlySpan<byte> src)
            => Read(head(src), (byte)src.Length);

        /// <summary>
        /// Reads up to 8 bytes from a data source reference, as determined by a specified {count} of bytes,
        /// and will likely incinerate the process with a segmentation fault if there aren't {count} bytes to read
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of bytes to read</param>
        [MethodImpl(Inline), Op]
        public static ulong Read(in byte src, byte count)
        {
            if(count == 1)
                return Read1(src);
            else if(count == 2)
                return Read2(src);
            else if(count == 3)
                return Read3(src);
            else if(count == 4)
                return Read4(src);
            else if(count == 5)
                return Read5(src);
            else if(count == 6)
                return Read6(src);
            else if(count == 7)
                return Read7(src);
            else if(count == 8)
                return Read8(src);
            else
                return 0;
        }

        /// <summary>
        /// Reads 1 byte from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong Read1(in byte src)
        {
            var dst = 0ul;
            seek8(ref dst, 0) = skip(src,0);
            return dst;        
        }
        
        /// <summary>
        /// Reads 2 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong Read2(in byte src)
        {
            var dst = 0ul;
            var i = 0;
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            return dst;        
        }

        /// <summary>
        /// Reads 3 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong Read3(in byte src)
        {
            var dst = 0ul;
            var i = 0;
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            return dst;        
        }

        /// <summary>
        /// Reads 4 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong Read4(in byte src)
        {
            var dst = 0ul;
            var i = 0;
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            return dst;        
        }

        /// <summary>
        /// Reads 5 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong Read5(in byte src)
        {
            var dst = 0ul;
            var i = 0;
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            return dst;        
        }

        /// <summary>
        /// Reads 6 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong Read6(in byte src)
        {
            var dst = 0ul;
            var i = 0;
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            return dst;        
        }

        /// <summary>
        /// Reads 7 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong Read7(in byte src)
        {
            var dst = 0ul;
            var i = 0;
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            return dst;        
        }

        /// <summary>
        /// Reads 8 bytes from a data source reference
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong Read8(in byte src)
        {
            var dst = 0ul;
            var i = 0;
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            return dst;        
        }

        [MethodImpl(Inline), Op]
        static ulong Read8_NoInc(in byte src)
        {
            var dst = 0ul;
            var i = 0;
            seek8(ref dst, 0) = skip(src, 0);
            seek8(ref dst, 1) = skip(src, 1);
            seek8(ref dst, 2) = skip(src, 2);
            seek8(ref dst, 3) = skip(src, 3);
            seek8(ref dst, 4) = skip(src, 4);
            seek8(ref dst, 5) = skip(src, 5);
            seek8(ref dst, 6) = skip(src, 6);
            seek8(ref dst, 7) = skip(src, 7);
            return dst;        
        }
    }
}