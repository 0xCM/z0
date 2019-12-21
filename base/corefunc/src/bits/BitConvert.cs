//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static AsIn;
    using static As;

    using static zfunc;

    public static class BitConvert
    {
        /// <summary>
        /// Allocates and fills a buffer with source bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> GetBytes<T>(in T src)
            where T : unmanaged
                => Bytes.read(in src);

        /// <summary>
        /// Converts a specified number of source elements to bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The source offset</param>
        /// <param name="count">The number of source elements to convert</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> GetBytes<T>(ReadOnlySpan<T> src, int offset, int count)
            where T : unmanaged
                => src.Slice(offset,count).AsBytes();

        /// <summary>
        /// Fills a caller-supplied buffer with source bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline)]
        public static void GetBytes<T>(in T src, Span<byte> dst)
            where T : unmanaged
                => Bytes.read(in src, dst);

        /// <summary>
        /// Fills a caller-supplied buffer with source bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline)]
        public static ref readonly Block64<byte> GetBytes(ulong src, in Block64<byte> dst)
        {         
            Bytes.read(in src, dst);
            return ref dst;
        }

        /// <summary>
        /// Fills a caller-supplied buffer with source bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline)]
        public static ref readonly Block32<byte> GetBytes(uint src, in Block32<byte> dst)
        {         
            Bytes.read(in src, dst);
            return ref dst;
        }

        /// <summary>
        /// Fills a caller-supplied buffer with source bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline)]
        public static ref readonly Block16<byte> GetBytes(ushort src, in Block16<byte> dst)
        {
            Bytes.read(in src, dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static short ToInt16(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.read<short>(src, offset);

        [MethodImpl(Inline)]
        public static ushort ToUInt16(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.read<ushort>(src, offset);

        [MethodImpl(Inline)]
        public static int ToInt32(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.read<int>(src,offset);

        [MethodImpl(Inline)]
        public static uint ToUInt32(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.read<uint>(src,offset);

        [MethodImpl(Inline)]
        public static long ToInt64(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.read<long>(src, offset);

        [MethodImpl(Inline)]
        public static ulong ToUInt64(ReadOnlySpan<byte> src, int offset = 0)
            => Bytes.read<ulong>(src, offset);

        [MethodImpl(Inline)]
        public static float ToSingle(int src)
            => BitConverter.Int32BitsToSingle(src);

        [MethodImpl(Inline)]
        public static float ToSingle(uint src)
            => BitConverter.Int32BitsToSingle((int)src);

        [MethodImpl(Inline)]
        public static double ToDouble(long src)
            => BitConverter.Int64BitsToDouble(src);

        [MethodImpl(Inline)]
        public static double ToDouble(ulong src)
            => BitConverter.Int64BitsToDouble((long)src);

        [MethodImpl(Inline)]
        public static int ToInt32(float src)
            => BitConverter.SingleToInt32Bits(src);

        [MethodImpl(Inline)]
        public static uint ToUInt32(float src)
            => (uint)BitConverter.SingleToInt32Bits(src);

        [MethodImpl(Inline)]
        public static long ToInt64(double src)
            => BitConverter.DoubleToInt64Bits(src);

        [MethodImpl(Inline)]
        public static ulong ToUInt64(double src)
            => (ulong)BitConverter.DoubleToInt64Bits(src);


    }

}